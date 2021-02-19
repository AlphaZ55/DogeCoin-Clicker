using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour
{
    
    public bool SellingCoin = false;
    public static int CashIncrease = 1;
    public int InternalIncrease;
    
    void Update()
    {
        CashIncrease = GlobalShop.shopPerSec;
        InternalIncrease = CashIncrease;
             if (SellingCoin == false )
        {
            SellingCoin = true;
            StartCoroutine(SellTheCoin());
        }
    }
    IEnumerator SellTheCoin ()
    {
        if (GlobalCoins.CoinCount == 0)
        {
            yield return new WaitForSeconds(1);
        }
        else 
        {
        GlobalCash.CashCount += InternalIncrease;
        GlobalCoins.CoinCount -= 1;
        yield return new WaitForSeconds(1);
        SellingCoin = false;
        }
    }
}
