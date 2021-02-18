using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
public AudioSource playSound;
{

    public GameObject AutoCoin;

    public void StartAutoCoin () {
        playSound.Play();
        AutoCoin.SetActive(true);
        GlobalCash.CashCount -= GlobalMiner.minerValue;
        GlobalMiner.minerValue *=2;
        GlobalMiner.turnOffButton = true;
        GlobalMiner.minerPerSec += 1;
        GlobalMiner.numberOfMiners += 1;
    }

}
