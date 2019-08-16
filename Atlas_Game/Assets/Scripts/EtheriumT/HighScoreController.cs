
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

using UnityEngine.UI;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.JsonRpc.UnityClient;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Util;

public class HighScoreController : MonoBehaviour
{
    public Text uiTextEtherBalance;
    
    public string url = "http://localhost:7545";

    //players wallet
    public string playerEthereumAccount = "0xF2dC4274c39f35ac21012Ed99ac6FbA84d348118";
    public string playerEthereumAccountPK = "9a8b378afd4cc61febc4b726f34d50973b1ccec6aaf649ca83e9382f027d53dc";

    //atlas wallet
    private string contractOwnerAddress = "0xB61eA17cb0F01E547aFA2fFd8aB58141328701e5";
    private string contractOwnerPK = "f488bcf58b72442ed024718962eef9001547881c4474dbba7030a0f892278798";  
    

    private static HighScoreController instance;

    public void run()
    {
        TransferEther();
    }
    
    public IEnumerator TransferEther()
    {
        var ethTransfer = new EthTransferUnityRequest(url, contractOwnerPK, contractOwnerAddress); //url, sender private key, sender address
        yield return ethTransfer.TransferEther(playerEthereumAccount, 1.0m, 40000); //reciever address

        if (ethTransfer.Exception != null)
        {
            Debug.Log(ethTransfer.Exception.Message);
            yield break;
        }

        var transactionHash = ethTransfer.Result;

        Debug.Log("Transfer transaction hash:" + transactionHash);

        //create a poll to get the receipt when mined
        var transactionReceiptPolling = new TransactionReceiptPollingRequest(url);
        //checking every 2 seconds for the receipt
        yield return transactionReceiptPolling.PollForReceipt(transactionHash, 2);

        Debug.Log("Transaction mined");

        var balanceRequest = new EthGetBalanceUnityRequest(url);
        yield return balanceRequest.SendRequest(playerEthereumAccount, BlockParameter.CreateLatest());

        Debug.Log(balanceRequest.ToString());

        uiTextEtherBalance.text = balanceRequest.ToString(); //not working to change the text

        Debug.Log("Balance of account:" + UnitConversion.Convert.FromWei(balanceRequest.Result.Value));
    }
    
    
}
