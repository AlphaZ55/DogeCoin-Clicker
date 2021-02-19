using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisasterScript : MonoBehaviour
{
    public GameObject statusBox;
    public float coinCheck;
    public int genChance;
    public bool disasterActive = false;
    public int coinLoss;

    void Update()
    {
        coinCheck = GlobalCoins.CoinCount / 10;
        if (disasterActive == false)
        {
            StartCoroutine(StartDisaster());
        }
        IEnumerator StartDisaster()
        {
            disasterActive = true;
            genChance = Random.Range(1, 20);
            if (coinCheck >= genChance)
            {
                coinLoss = Mathf.RoundToInt(GlobalCoins.CoinCount * 0.25f);
                statusBox.GetComponent<Text>().text = "You lost " + coinLoss + " coins in a hard drive failure!";
                GlobalCoins.CoinCount -= coinLoss;
                yield return new WaitForSeconds(5);
                statusBox.GetComponent<Animation>().Play("StatusAnim");
                yield return new WaitForSeconds(1);
                statusBox.SetActive(false);
                statusBox.SetActive(true);
            }
            yield return new WaitForSeconds(10);
            disasterActive = false;
        }
    }
}
