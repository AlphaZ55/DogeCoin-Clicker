using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButtonClick : MonoBehaviour
{
    public GameObject textBox;

    public void ClickTheButton () {
        GlobalCoins.CoinCount += 1;
    }
}
