using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRightL2 : MonoBehaviour
{
    public GameObject[] carPrefabs;
    private float spawnPosZRight = 80;
    private float startDelay = 1;
    private float spawnInterval1 = 1.9f;
    private float spawnInterval2 = 2.3f;
    private float spawnInterval3 = 2.1f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCar1", startDelay, spawnInterval1);
        InvokeRepeating("SpawnRandomCar2", startDelay, spawnInterval2);
        InvokeRepeating("SpawnRandomCar3", startDelay, spawnInterval3);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomCar1()
    {
        int carIndex4 = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos4 = new Vector3(Random.Range(40, 40), 5, spawnPosZRight);
        Instantiate(carPrefabs[carIndex4], spawnPos4, carPrefabs[carIndex4].transform.rotation);

        int carIndex7 = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos7 = new Vector3(Random.Range(69, 69), 5, spawnPosZRight);
        Instantiate(carPrefabs[carIndex7], spawnPos7, carPrefabs[carIndex7].transform.rotation);

        int carIndex2 = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos2 = new Vector3(Random.Range(119, 119), 5, spawnPosZRight);
        Instantiate(carPrefabs[carIndex2], spawnPos2, carPrefabs[carIndex2].transform.rotation);

    }
    void SpawnRandomCar2()
    {

        int carIndex5 = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos5 = new Vector3(Random.Range(49, 49), 5, spawnPosZRight);
        Instantiate(carPrefabs[carIndex5], spawnPos5, carPrefabs[carIndex5].transform.rotation);

        int carIndex8 = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos8 = new Vector3(Random.Range(99, 99), 5, spawnPosZRight);
        Instantiate(carPrefabs[carIndex8], spawnPos8, carPrefabs[carIndex8].transform.rotation);

    }
    void SpawnRandomCar3()
    {
        int carIndex6 = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos6 = new Vector3(Random.Range(59, 59), 5, spawnPosZRight);
        Instantiate(carPrefabs[carIndex6], spawnPos6, carPrefabs[carIndex6].transform.rotation);


        int carIndex9 = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos9 = new Vector3(Random.Range(109, 109), 5, spawnPosZRight);
        Instantiate(carPrefabs[carIndex9], spawnPos9, carPrefabs[carIndex9].transform.rotation);
    }

}
