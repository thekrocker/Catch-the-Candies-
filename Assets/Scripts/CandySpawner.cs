using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    [SerializeField] private float maxX; // boundary for spawner... around -6.5x would be cool

    public GameObject[] candies;
    void Start()
    {
        SpawnCandy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCandy()
    {
        int rand = Random.Range(0, candies.Length);

        
        Instantiate(candies[rand], transform.position, transform.rotation);
    }
}
