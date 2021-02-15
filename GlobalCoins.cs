using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCoins : MonoBehaviour
{
    public static int CoinCount;
    public GameObject CoinDisplay;
    public int InternalCoin;

    void Update()
    {
        InternalCoin = CoinCount;
        CoinDisplay.GetComponent<Text>().text = "Coins: " + InternalCoin;

        
    }
}
