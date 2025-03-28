using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject cloudPrefab;
    public float spawnRate = 5; // Bulutlar daha sýk çýkabilir
    private float timer = 0;
    public float heightOffset = 15; // Bulutlar daha yukarý çýkabilir

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnCloud();
            timer = 0;
        }
    }

    void SpawnCloud()
    {
        float highestPoint = transform.position.y + heightOffset;
        float lowestPoint = transform.position.y - heightOffset;

        Vector3 spawnPosition = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 1); // Z = 1 (Arka planda kalacak)

        Instantiate(cloudPrefab, spawnPosition, Quaternion.identity);
    }

}
