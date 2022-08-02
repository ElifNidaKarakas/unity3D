using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    public GameObject[] Prefabs;
    private float spawnRangeX= 20;
    private float spawnPosZ = 20;
    
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
             public int engelIndex;
             Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
          0,spawnPosZ);
          int engelIndex = Random.Range(0,Prefabs.Lenght);
          Instantiate(animalPrefabs[animalIndex],spawnPos,Prefabs[animalIndex].transform.rotation);

        }
        
    }
}
