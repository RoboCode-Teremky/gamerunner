using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; 

    public int totalCoins = 0;
    public Text coinText; 

    private void Awake()
    {
        if (instance == null)
        {
            instance = this; 
        }
    }

    public void AddCoins(int coinsToAdd)
    {
        totalCoins += coinsToAdd;
        UpdateCoinText(); 
    }

    void UpdateCoinText()
    {
        coinText.text = "Coins: " + totalCoins.ToString(); 
    }
}