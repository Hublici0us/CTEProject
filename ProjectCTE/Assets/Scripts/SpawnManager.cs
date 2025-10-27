using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnables;
    GameObject[] spawnPoints;
    float spawnInterval = 3.0f;
    public int freeSpots = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");
        StartCoroutine(SpawnObjects());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    GameObject SpawnRandomItem()
    {
        int random = Random.Range(0, spawnables.Length);

        return spawnables[random];
    }

    void SpawnRandomPosition()
    {
        int random = Random.Range(0, spawnPoints.Length);

        while (spawnPoints[random].transform.childCount > 0 )
        {
            random = Random.Range(0, spawnPoints.Length);
        }

        Instantiate(SpawnRandomItem(), spawnPoints[random].transform);
    }

    int CheckForFreeSpots()
    {
        freeSpots = 0;

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (spawnPoints[i].transform.childCount == 0)
            {
                freeSpots++;
            }
        }

        return freeSpots;
    }

    IEnumerator SpawnObjects()
    {
        yield return new WaitForSeconds(spawnInterval);

        while (CheckForFreeSpots() > 0)
        {
            SpawnRandomPosition();
            yield return new WaitForSeconds(spawnInterval);
        }

        yield return new WaitForSeconds(spawnInterval);
    }
}
