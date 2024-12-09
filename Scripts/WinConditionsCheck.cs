using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinConditionsCheck : MonoBehaviour
{
    public int enemySpawnerCount = 0;
    public int enemyCount = 0;

    public GameManager gameManager;

    void Update()
    {
        CheckGameOver();
    }

    void CheckGameOver()
    {
        enemySpawnerCount = GameObject.FindGameObjectsWithTag("EnemySpawner").Length;
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (enemySpawnerCount == 0 && enemyCount == 0 && gameManager.loose == false)
        {
            gameManager.WinStartGameOverSequences();
        }
    }
}
