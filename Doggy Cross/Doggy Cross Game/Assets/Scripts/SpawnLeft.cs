using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLeft : MonoBehaviour
{
    public GameObject[] carPrefabs;
    private float spawnPosZLeft = -40;
    private float startDelay = 2;
    private float spawnInterval4 = 1.8f;
    private float spawnInterval5 = 2.2f;
    private float spawnInterval6 = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCar4", startDelay, spawnInterval4);
        InvokeRepeating("SpawnRandomCar5", startDelay, spawnInterval5);
        InvokeRepeating("SpawnRandomCar6", startDelay, spawnInterval6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomCar4()
    {
        int carIndex4 = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos4 = new Vector3(Random.Range(17, 17), 5, spawnPosZLeft);
        Instantiate(carPrefabs[carIndex4], spawnPos4, carPrefabs[carIndex4].transform.rotation);

    }
    void SpawnRandomCar5()
    {
        int carIndex5 = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos5 = new Vector3(Random.Range(7, 7), 5,-44);
        Instantiate(carPrefabs[carIndex5], spawnPos5, carPrefabs[carIndex5].transform.rotation);

    }
    void SpawnRandomCar6()
    {
        int carIndex6 = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos6 = new Vector3(Random.Range(2, 2), 5, spawnPosZLeft);
        Instantiate(carPrefabs[carIndex6], spawnPos6, carPrefabs[carIndex6].transform.rotation);
    }
}
