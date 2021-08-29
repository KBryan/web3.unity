using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OfflineSigning : MonoBehaviour
{
    async void Start()
    {
        // set chain: ethereum, moonbeam, polygon etc
        string chain = "ethereum";
        // set network mainnet, testnet
        string network = "rinkeby";
        // smart contract method to call
        string method = "getHash";
        // abi in json format
        string abi = "[{\"inputs\": [{\"internalType\": \"bytes32\",\"name\": \"_messageHash\",\"type\": \"bytes32\"}],\"name\": \"getEthSignedMessageHash\",\"outputs\": [{\"internalType\": \"bytes32\",\"name\": \"\",\"type\": \"bytes32\"}],\"stateMutability\": \"pure\",\"type\": \"function\"},{\"inputs\": [{\"internalType\": \"string\",\"name\": \"str\",\"type\": \"string\"}],\"name\": \"getHash\",\"outputs\": [{\"internalType\": \"bytes32\",\"name\": \"\",\"type\": \"bytes32\"}],\"stateMutability\": \"pure\",\"type\": \"function\"},{\"inputs\": [{\"internalType\": \"address\",\"name\": \"_to\",\"type\": \"address\"},{\"internalType\": \"uint256\",\"name\": \"_amount\",\"type\": \"uint256\"},{\"internalType\": \"string\",\"name\": \"_message\",\"type\": \"string\"},{\"internalType\": \"uint256\",\"name\": \"_nonce\",\"type\": \"uint256\"}],\"name\": \"getMessageHash\",\"outputs\": [{\"internalType\": \"bytes32\",\"name\": \"\",\"type\": \"bytes32\"}],\"stateMutability\": \"pure\",\"type\": \"function\"},{\"inputs\": [{\"internalType\": \"bytes32\",\"name\": \"_ethSignedMessageHash\",\"type\": \"bytes32\"},{\"internalType\":\"bytes\",\"name\": \"_signature\",\"type\": \"bytes\"}],\"name\": \"recoverSigner\",\"outputs\": [{\"internalType\": \"address\",\"name\": \"\",\"type\": \"address\"}],\"stateMutability\": \"pure\",\"type\": \"function\"},{\"inputs\": [{\"internalType\": \"bytes\",\"name\": \"sig\",\"type\": \"bytes\"}],\"name\": \"splitSignature\",\"outputs\": [{\"internalType\": \"bytes32\",\"name\": \"r\",\"type\": \"bytes32\"},{\"internalType\": \"bytes32\",\"name\": \"s\",\"type\": \"bytes32\"},{\"internalType\": \"uint8\",\"name\": \"v\",\"type\": \"uint8\"}],\"stateMutability\": \"pure\",\"type\": \"function\"},{\"inputs\": [{\"internalType\": \"address\",\"name\": \"_signer\",\"type\": \"address\"},{\"internalType\": \"address\",\"name\": \"_to\",\"type\": \"address\"},{\"internalType\": \"uint256\",\"name\": \"_amount\",\"type\": \"uint256\"},{\"internalType\": \"string\",\"name\": \"_message\",\"type\": \"string\"},{\"internalType\": \"uint256\",\"name\": \"_nonce\",\"type\": \"uint256\"},{\"internalType\": \"bytes\",\"name\": \"signature\",\"type\": \"bytes\"}],\"name\": \"verify\",\"outputs\": [{\"internalType\": \"bool\",\"name\": \"\",\"type\": \"bool\"}],\"stateMutability\": \"pure\",\"type\": \"function\"}]";
        // address of contract
        string contract = "0x8cb0bA41A8aE716B4878BC671b0f796bc8e33960";
        // array of arguments for contract
        string args = "[\"Chain Safe Gaming\"]";
        // connects to user's browser wallet to call a transaction
        string response = await EVM.Call(chain, network, contract, abi, method, args);
        // display response in game
        print(response);
    }
}