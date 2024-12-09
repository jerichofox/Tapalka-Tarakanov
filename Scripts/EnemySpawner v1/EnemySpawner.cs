using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    GameObject _enemyPrefab;
    [SerializeField]
    float _minimumSpawnTime;
    [SerializeField]
    float _maximumSpawnTime;
    [SerializeField] // New field
    float _destroyAfterSeconds = 6f; // Set to 6 seconds

    float _timeUntilSpawn;
    float _timeUntilDestroy;  
       

    void Awake()
    {
        SetTimeUntilSpawn();
        _timeUntilDestroy = _destroyAfterSeconds; // Initialize destroy timer
    }

    void Update()
    {
        _timeUntilSpawn -= Time.deltaTime;
        _timeUntilDestroy -= Time.deltaTime;

        if (_timeUntilSpawn <= 0)
        {
            Instantiate(_enemyPrefab, transform.position, Quaternion.identity);           
            SetTimeUntilSpawn();
        }

        if (_timeUntilDestroy <= 0)
        {
            Destroy(gameObject); // Destroy the spawner when time is up
        }
    }

    void SetTimeUntilSpawn()
    {
        _timeUntilSpawn = Random.Range(_minimumSpawnTime, _maximumSpawnTime);
    }
}
