using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject uiPanel; 

    private bool isPanelOpen = false;

    void Start()
    {
       
        uiPanel.SetActive(false);
    }

    public void TogglePanel()
    {
        isPanelOpen = !isPanelOpen;

        if (isPanelOpen)
        {
           
            Time.timeScale = 0;
         
            uiPanel.SetActive(true);
        }
        else
        {
         
            Time.timeScale = 1;
        
            uiPanel.SetActive(false);
        }
    }
}