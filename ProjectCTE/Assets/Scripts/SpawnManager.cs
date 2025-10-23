using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    GameObject[] spawnables;
    GameObject[] spawnPoints;
    float spawnInterval;
    Camera cam = Camera.main;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
