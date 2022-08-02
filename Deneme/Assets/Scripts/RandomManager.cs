using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomManager : MonoBehaviour
{
   public GameObject[] engelPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEngel",startDelay,spawnInterval);

        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    void SpawnRandomEngel() {
        // Rasgele nesneleri olusturuyoruz
            Vector3 spawnpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            int engelIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(Prefabs[engelIndex], spawnpos, Prefabs[engelIndex].transform.rotation);

    }
}
}
