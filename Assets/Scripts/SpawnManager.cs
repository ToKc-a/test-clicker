using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Monster;
    public float minSpawnDelay = 1f;
    public float maxSpawnDelay = 5f;
    public float spawnXLimit = 2.2f;
    public float spawnYLimit = 3f;
    private GameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        Spawn();
    }

    void Spawn()
    {
        float randomX = Random.Range(-spawnXLimit, spawnXLimit);
        float randomY = Random.Range(-spawnYLimit, spawnYLimit);
        Vector3 spawnPos = transform.position + new Vector3(randomX, randomY, 0f);
        int i = Random.Range(0, Monster.Length);
        Instantiate(Monster[i], spawnPos, Quaternion.identity);

        gameManager.MonsterLimit();

        Invoke("Spawn", Random.Range(minSpawnDelay, maxSpawnDelay));
    }
}
