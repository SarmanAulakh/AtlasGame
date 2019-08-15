/*
using Nethereum.ABI.Encoders;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using Nethereum.Hex.HexConvertors.Extensions;
using Nethereum.Hex.HexTypes;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Signer;
using System.Numerics;

/// <summary>
/// This class wraps our Ethereum Smart Contract (which can be examined here https://rinkeby.etherscan.io/address/0xcd602de18ef419253da7be962d3f1d05da3dea33), making 
/// it easier to interact with in this project.
/// The code is a reduced and simplified version of the Nethereum sample https://github.com/Nethereum/Nethereum.Flappy/blob/master/Scripts/TopScoreService.cs
/// Notice this is not a MonoBehaviour.
/// </summary>
public class HighScoreContractWrapper
{
    public static string contractABI = @"[{'constant':false,'inputs':[{'name':'score','type':'int256'},{'name':'v','type':'uint8'},{'name':'r','type':'bytes32'},{'name':'s','type':'bytes32'}],'name':'setTopScore','outputs':[],'payable':false,'type':'function'},{'constant':true,'inputs':[{'name':'','type':'uint256'}],'name':'topScores','outputs':[{'name':'addr','type':'address'},{'name':'score','type':'int256'}],'payable':false,'type':'function'},{'constant':false,'inputs':[],'name':'getCountTopScores','outputs':[{'name':'','type':'uint256'}],'payable':false,'type':'function'},{'constant':true,'inputs':[{'name':'','type':'address'}],'name':'userTopScores','outputs':[{'name':'','type':'int256'}],'payable':false,'type':'function'},{'inputs':[],'payable':false,'type':'constructor'}]";

    private static string contractAddress = "0xcd602de18ef419253da7be962d3f1d05da3dea33";
    private Contract contract;

    public HighScoreContractWrapper()
    {
        this.contract = new Contract(null, contractABI, contractAddress);
    }
    
    public Function GetFunctionTopScores()
    {
        return contract.GetFunction("topScores");
    }
    
    public Function GetFunctionGetCountTopScores()
    {
        return contract.GetFunction("getCountTopScores");
    }

    public CallInput CreateTopScoresCallInput(BigInteger index)
    {
        var function = GetFunctionTopScores();
        return function.CreateCallInput(index);
    }
        
    public CallInput CreateCountTopScoresCallInput()
    {
        var function = GetFunctionGetCountTopScores();
        return function.CreateCallInput();
    }
    
    public Function GetFunctionSetTopScore()
    {
        return contract.GetFunction("setTopScore");
    }
    
    public TransactionInput CreateSetTopScoreTransactionInput(string addressFrom, string addressOwner, string privateKey, BigInteger score, HexBigInteger gas = null, HexBigInteger valueAmount = null)
    {
        var numberBytes = new IntTypeEncoder().Encode(score);
        var sha3 = new Nethereum.Util.Sha3Keccack();
        var hash = sha3.CalculateHashFromHex(addressFrom, addressOwner, numberBytes.ToHex());
        var signer = new MessageSigner();
        var signature = signer.Sign(hash.HexToByteArray(), privateKey);
        var ethEcdsa = MessageSigner.ExtractEcdsaSignature(signature);

        var function = GetFunctionSetTopScore();
        return function.CreateTransactionInput(addressFrom, gas, valueAmount, score, ethEcdsa.V, ethEcdsa.R, ethEcdsa.S);
    }

    public int DecodeTopScoreCount(string result)
    {
        var function = GetFunctionGetCountTopScores();
        return function.DecodeSimpleTypeOutput<int>(result);
    }
    
    public HighScoreDataTypeDefinition DecodeTopScoreDTO(string result)
    {
        var function = GetFunctionTopScores();
        return function.DecodeDTOTypeOutput<HighScoreDataTypeDefinition>(result);
    }
}

[FunctionOutput]
public class HighScoreDataTypeDefinition
{
    [Parameter("address", "addr", 1)]
    public string Addr { get; set; }

    [Parameter("int256", "score", 2)]
    public BigInteger Score { get; set; }
}
*/
