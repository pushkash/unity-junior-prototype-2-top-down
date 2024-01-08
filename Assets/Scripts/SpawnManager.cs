using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int xRange = 10;
    public float zPos = 20;
    public float startDelay = 2;

    // Start is called before the first frame update
    void Start()
    {
        float randomDelayInSecs = Random.Range(0, 3);

        InvokeRepeating("SpawnRandomAnimals", startDelay, randomDelayInSecs);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomAnimals()
    {
        int arrayIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 elementPos = new Vector3(Random.Range(-xRange, xRange), 0, zPos);

        Instantiate(animalPrefabs[arrayIndex], elementPos, animalPrefabs[arrayIndex].transform.rotation);
    }
}
