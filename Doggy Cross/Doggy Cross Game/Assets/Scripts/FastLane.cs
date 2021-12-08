using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastLane : MonoBehaviour
{
    public GameObject[] carPrefabs2;
    private float spawnPosZL = -60;
    private float startDelay = 0;
    private float spawnInterval1 = 1f;
   // private float spawnInterval2 = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCar1", startDelay, spawnInterval1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomCar1()
    {
        int carIndex1 = Random.Range(0, carPrefabs2.Length);
        Vector3 spawnPos1 = new Vector3(Random.Range(82, 87), 5, spawnPosZL);
        Instantiate(carPrefabs2[carIndex1], spawnPos1, carPrefabs2[carIndex1].transform.rotation);

        int carIndex2 = Random.Range(0, carPrefabs2.Length);
        Vector3 spawnPos2 = new Vector3(Random.Range(137,143), 5, spawnPosZL);
        Instantiate(carPrefabs2[carIndex2], spawnPos2, carPrefabs2[carIndex2].transform.rotation);
    }

    }
