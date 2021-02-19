using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour {

    public int savedCoins;
    public int savedCash;
    public int savedRigs;
    public int savedShops;
    public int savedValue;


    void Start(){
    
        if (MainMenuOptions.isLoading == true)
        {
            savedCoins = PlayerPrefs.GetInt("SavedCoins");
            GlobalCoins.CoinCount = savedCoins;
            savedCash = PlayerPrefs.GetInt("SavedCash");
            GlobalCash.CashCount = savedCash;
            savedRigs = PlayerPrefs.GetInt("SavedRigs");
            GlobalMiner.minerPerSec = savedRigs;
            savedShops = PlayerPrefs.GetInt("SavedShops");
            GlobalShop.numberOfShops = savedShops;
            savedValue = PlayerPrefs.GetInt("SaveValue");
            SaveGame.saveValue = savedValue;
        }
    }
}
