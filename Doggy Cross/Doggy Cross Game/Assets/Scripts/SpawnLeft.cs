using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnLeft : MonoBehaviour
{
    public GameObject[] carPrefabs;
    private float spawnPosZLeft = -50;
    private float startDelay = 1.5f;
    private float startDelay2 = 1;
    private float spawnInterval4 = 2.1f;
    private float spawnInterval5 = 2.2f;
    private float spawnInterval6 = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCar4", startDelay, spawnInterval4);
        InvokeRepeating("SpawnRandomCar5", startDelay2, spawnInterval5);
        InvokeRepeating("SpawnRandomCar6", startDelay, spawnInterval6);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomCar4()
    {
        int carIndex1 = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos1 = new Vector3(Random.Range(17, 17), 5, spawnPosZLeft);
        Instantiate(carPrefabs[carIndex1], spawnPos1, carPrefabs[carIndex1].transform.rotation);

        int carIndex2 = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos2 = new Vector3(Random.Range(35, 35), 5, spawnPosZLeft);
        Instantiate(carPrefabs[carIndex2], spawnPos2, carPrefabs[carIndex2].transform.rotation);

        int carIndex3 = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos3 = new Vector3(Random.Range(64,64), 5, spawnPosZLeft);
        Instantiate(carPrefabs[carIndex3], spawnPos3, carPrefabs[carIndex3].transform.rotation);

        int carIndex10 = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos10 = new Vector3(Random.Range(124, 124), 5, spawnPosZLeft);
        Instantiate(carPrefabs[carIndex10], spawnPos10, carPrefabs[carIndex10].transform.rotation);

    }
    void SpawnRandomCar5()
    {
        int carIndex5 = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos5 = new Vector3(Random.Range(7, 7), 5,-44);
        Instantiate(carPrefabs[carIndex5], spawnPos5, carPrefabs[carIndex5].transform.rotation);

        int carIndex4 = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos4 = new Vector3(Random.Range(44, 44), 5, spawnPosZLeft);
        Instantiate(carPrefabs[carIndex4], spawnPos4, carPrefabs[carIndex4].transform.rotation);

        int carIndex8 = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos8 = new Vector3(Random.Range(104, 104), 5, spawnPosZLeft);
        Instantiate(carPrefabs[carIndex8], spawnPos8, carPrefabs[carIndex8].transform.rotation);

    }
    void SpawnRandomCar6()
    {
        int carIndex6 = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos6 = new Vector3(Random.Range(2, 2), 5, spawnPosZLeft);
        Instantiate(carPrefabs[carIndex6], spawnPos6, carPrefabs[carIndex6].transform.rotation);

        int carIndex7 = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos7 = new Vector3(Random.Range(54, 54), 5, spawnPosZLeft);
        Instantiate(carPrefabs[carIndex7], spawnPos7, carPrefabs[carIndex7].transform.rotation);

        int carIndex9 = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos9 = new Vector3(Random.Range(114, 114), 5, spawnPosZLeft);
        Instantiate(carPrefabs[carIndex9], spawnPos9, carPrefabs[carIndex9].transform.rotation);
    }
}
