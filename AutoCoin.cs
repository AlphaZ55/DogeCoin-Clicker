using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCoin : MonoBehaviour
{
    
    public bool CreatingCoin = false;
    public static int CoinIncrease = 1;
    public int InternalIncrease;
    void Update()
    {
        InternalIncrease = CoinIncrease;
        if (CreatingCoin == false )
        {
            CreatingCoin = true;
            StartCoroutine(CreateTheCoin());
        }
    }
    IEnumerator CreateTheCoin ()
    {
        GlobalCoins.CoinCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingCoin = false;
    }
}
