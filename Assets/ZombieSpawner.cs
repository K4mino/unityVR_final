using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    
    public GameObject zombiePrefab;
    public Transform[] spawnPoints; 
    public float spawnInterval = 5f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnZombie), spawnInterval, spawnInterval);
    }

    private void SpawnZombie()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(zombiePrefab, spawnPoints[randomIndex].position, Quaternion.identity);
    }
}
