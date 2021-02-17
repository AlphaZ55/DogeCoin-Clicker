using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalMiner : MonoBehaviour
{
 
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int minerValue = 50;
    public static bool turnOffButton = false;

    void Update()
    {
        currentCash = GlobalCash.CashCount;
        fakeText.GetComponent<Text>().text = "Buy Baker - $" + minerValue;
        realText.GetComponent<Text>().text = "Buy Baker - $" + minerValue;
        if (currentCash >= minerValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
         if (turnOffButton == true){
             realButton.SetActive(false);
             fakeButton.SetActive(true);
             turnOffButton = false;

         }
    }
}
