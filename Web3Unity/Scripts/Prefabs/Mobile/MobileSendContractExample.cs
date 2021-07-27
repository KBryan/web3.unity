using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class MobileSendContractExample: MonoBehaviour
{
    public async void OnSendContract()
    {
        string privateKey = "78dae1a22c7507a4ed30c06172e7614eb168d3546c13856340771e63ad3c0081"; // PlayerPrefs.GetString("privateKey"); 
        string account = "0x428066dd8A212104Bc9240dCe3cdeA3D3A0f7979"; // _Config.Account;
        string chain = "ethereum";
        string network = "rinkeby";
        string contract = "0xB6B8bB1e16A6F73f7078108538979336B9B7341C";
        string value = "0"; // in wei
        string abi = "[{\"inputs\":[],\"name\":\"increment\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"x\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"}]";
        string method = "increment";
        string args = "[]";

        string transaction = await EVM.CreateTransaction(chain, network, contract, abi, method, args);
        string gasLimit = await EVM.GasLimit(chain, network, contract, value, transaction);
        string nonce = await EVM.Nonce(chain, network, account);
        string gasPrice = await EVM.GasPrice(chain, network);
        string signedTransaction = EVM.SignTransaction(privateKey, contract, value, nonce, gasPrice, gasLimit, transaction);
        string receipt = await EVM.BroadcastTransaction(chain, network, signedTransaction);
        print("https://rinkeby.etherscan.io/tx/" + receipt);
    }
}
