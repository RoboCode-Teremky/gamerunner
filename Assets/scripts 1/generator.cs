using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
    [SerializeField] private GameObject[] platformPrefabs;
    [SerializeField] private int platformLimit = 10;
    [SerializeField] public float generatorCooldown = 15.0f;
    void Start()
    {
        Random.InitState(LevelSeed.seed);
        StartCoroutine(GeneratePlatform());
    }

    private IEnumerator GeneratePlatform()
    {
        for (int i = 0; i < platformLimit; i++)
        {
            GameObject platform = Instantiate(platformPrefabs[Random.Range(0, platformPrefabs.Length - 1)], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(generatorCooldown);
        }
        //Instantiate(platformPrefabs[platformPrefabs.Length - 1], transform.position, Quaternion.identity); // Фінішна пряма
    }
}  