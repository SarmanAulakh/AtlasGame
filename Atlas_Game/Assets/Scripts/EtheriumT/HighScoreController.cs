
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.JsonRpc.UnityClient;

public class HighScoreController : MonoBehaviour
{
    public Text uiTextEtherBalance;
    
    public string networkUrl = "HTTP://127.0.0.1:7545";

    //players wallet
    public string playerEthereumAccount = "0xF2dC4274c39f35ac21012Ed99ac6FbA84d348118";
    public string playerEthereumAccountPK = "9a8b378afd4cc61febc4b726f34d50973b1ccec6aaf649ca83e9382f027d53dc";

    //atlas wallet
    private string contractOwnerAddress = "0xB61eA17cb0F01E547aFA2fFd8aB58141328701e5";
    private string contractOwnerPK = "f488bcf58b72442ed024718962eef9001547881c4474dbba7030a0f892278798";  
    
    private IEnumerator getAccountBalanceCoroutine;

    private static HighScoreController instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // Prepare our coroutines            
        getAccountBalanceCoroutine = GetAccountBalanceCoroutine();
    }

    public void GetAccountBalance()
    {
        // Get address balance 
        StopCoroutine(getAccountBalanceCoroutine);
        getAccountBalanceCoroutine = GetAccountBalanceCoroutine();
        StartCoroutine(getAccountBalanceCoroutine);

        Debug.Log(getAccountBalanceCoroutine);
    }
    
    // Check Ether balance of the player account
    public IEnumerator GetAccountBalanceCoroutine()
    {
        var getBalanceRequest = new EthGetBalanceUnityRequest(networkUrl);           // 1
                                                                                     // Send balance request with player's account, asking for balance in latest block
        yield return getBalanceRequest.SendRequest(playerEthereumAccount, Nethereum.RPC.Eth.DTOs.BlockParameter.CreateLatest());  // 2

        if (getBalanceRequest.Exception == null)                                     // 3
        {
            var balance = getBalanceRequest.Result.Value;                             // 4
                                                                                      // Convert the balance from wei to ether and round to 8 decimals for display                                
            uiTextEtherBalance.text =
              Nethereum.Util.UnitConversion.Convert.FromWei(balance, 18).ToString("n8");    // 5
        }
        else
        {
            Debug.Log("RW: Get Account Balance gave an exception: " + getBalanceRequest.Exception.Message);
        }
    }

    private string PrettifyAddress(string addr)
    {
        if (addr.ToLowerInvariant() == playerEthereumAccount.ToLowerInvariant())
        {
            return "Me";
        }
        else
        {
            return addr;
        }
    }

    public void OnRefreshButtonPressed()
    {
        GetAccountBalance();
    }
}
