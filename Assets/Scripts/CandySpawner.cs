using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using Random = UnityEngine.Random;

public class CandySpawner : MonoBehaviour
{
    [SerializeField] private float maxX; // boundary for spawner... around -6.5x would be cool

    public GameObject[] candies;

    [SerializeField] private float spawnInterval;

    public static CandySpawner instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        StartSpawningCandies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCandy()
    {
        int rand = Random.Range(0, candies.Length);
        
        float randX = Random.Range(-maxX, maxX); // randomly gives value of candies between boundaries in X axis.
        
        Vector3 randomPos = new Vector3(randX, transform.position.y, transform.position.z);
        
        Instantiate(candies[rand],randomPos, transform.rotation); // Instantiating candies at random position
    }

    IEnumerator SpawnCandies()
    {
        yield return new WaitForSeconds(2f); // wait 2 secs to respawn 
        
        while (true)
        {
            SpawnCandy();

            yield return new WaitForSeconds(spawnInterval);
        }
        
    }

    public void StartSpawningCandies()
    {
        StartCoroutine(SpawnCandies());
    }

    public void StopSpawningCandies()
    {
        StopCoroutine(SpawnCandies());
    }
    
    
}
