using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellCoin : MonoBehaviour
{
    public GameObject textBox;

    public void ClickTheButton () {
        GlobalCoins.CoinCount -= 1;
        GlobalCash.CashCount += 1;
    }
}
