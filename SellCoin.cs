using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellCoin : MonoBehaviour {

    public GameObject textBox;
    public GameObject statusBox;

    public void ClickTheButton () {

        if (GlobalCoins.CoinCount == 0) 
        {
        statusBox.GetComponent<Text>().text = "Not enough Coins to sell!";
        statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else 
        {
        GlobalCoins.CoinCount -= 1;
        GlobalCash.CashCount += 1;
        }
    }
}
