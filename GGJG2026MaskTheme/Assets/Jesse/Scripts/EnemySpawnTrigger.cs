using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnTrigger : MonoBehaviour
{
    [Header("Spawning")]
    public GameObject[] enemyPrefabs;
    public Transform spawnLocations;
    public int enemyCount = 3;

    [Header("Doors")]
    public GameObject[] doors;

    private List<GameObject> aliveEnemies = new List<GameObject>();
    private bool triggered = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (triggered) return;
        if (!other.CompareTag("Player")) return;

        triggered = true;
        CloseDoors();
        SpawnEnemies();
    }

    void SpawnEnemies()
    {
        for (int i = 0; i < enemyCount; i++)
        {
            Transform spawnPoint =
                spawnLocations[Random.Range(0, spawnLocations.Length)];

            GameObject prefab =
                enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];

            GameObject enemy = Instantiate(
                prefab,
                spawnPoint.position,
                Quaternion.identity
            );

            aliveEnemies.Add(enemy);

            Enemy enemyScript = enemy.GetComponent<Enemy>();
            if (enemyScript != null)
            {
                enemyScript.onDeath += OnEnemyDeath;
            }
        }
    }

    void OnEnemyDeath(GameObject enemy)
    {
        aliveEnemies.Remove(enemy);

        if (aliveEnemies.Count == 0)
        {
            OpenDoors();
        }
    }

    void CloseDoors()
    {
        foreach (GameObject door in doors)
        {
            door.SetActive(true);
        }
    }

    void OpenDoors()
    {
        foreach (GameObject door in doors)
        {
            door.SetActive(false);
        }
    }
}
