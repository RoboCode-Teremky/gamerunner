using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    public GameObject FPanel; 

    void Start()
    {
        FPanel.SetActive(false);

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            PlayerPrefs.SetInt(MainMenu.OBTAINED_LEVEL_KEY, LevelSeed.seed);
            Time.timeScale = 0;
            FPanel.SetActive(true);

        }

        else
        {
         
            Time.timeScale = 1;
        
            FPanel.SetActive(false);
        }
    }
}