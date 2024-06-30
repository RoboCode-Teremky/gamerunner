using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevwee : MonoBehaviour
{
    public void nextLvl()
    {
        LevelSeed.seed +=1;
        SceneManager.LoadScene("game");
    }
}
