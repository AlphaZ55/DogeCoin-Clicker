using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{

    public GameObject AutoCoin;
    public GameObject AutoSell;
    public AudioSource playSound;

    public void StartAutoCoin () {
        playSound.Play();
        AutoCoin.SetActive(true);
        GlobalCash.CashCount -= GlobalMiner.minerValue;
        GlobalMiner.minerValue *=2;
        GlobalMiner.turnOffButton = true;
        GlobalMiner.minerPerSec += 1;
        GlobalMiner.numberOfMiners += 1;
    }
    public void StartAutoSell () {
        playSound.Play();
        AutoSell.SetActive(true);
        GlobalCash.CashCount -= GlobalShop.shopValue;
        GlobalShop.shopValue *=2;
        GlobalShop.turnOffButton = true;
        GlobalShop.shopPerSec += 1;
        GlobalShop.numberOfShops += 1;
    }

}