using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellCoin : MonoBehaviour {

    public GameObject textBox;
    public GameObject statusBox;
    public AudioSource cashOne;
    public AudioSource cashTwo;
    public int genTone;

    public void ClickTheButton () {
        genTone = Random.Range(1, 3);
        if (GlobalCoins.CoinCount == 0) 
        {
        statusBox.GetComponent<Text>().text = "Not enough Coins to sell!";
        statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else 
        {
        if (genTone == 1)
        {
            cashOne.Play();
        }
        if (genTone == 2)
        {
            cashTwo.Play();
        }
        GlobalCoins.CoinCount -= 1;
        GlobalCash.CashCount += 1;
        }
    }
}
