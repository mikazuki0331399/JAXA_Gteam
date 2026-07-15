using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefabs;

    public Transform leftSpawn;
    public Transform rightSpawn;
    public Transform leftBackSpawn;
    public Transform rightBackSpawn;

    void Start()
    {
        InvokeRepeating(
            nameof(SpawnEnemy),
            1f,
            2f
        );
    }

    void SpawnEnemy()
    {
        int rand = Random.Range(0, 4);

        Transform spawnPoint = null;
        Vector3 direction = Vector3.zero;

        switch (rand)
        {
            case 0:
                spawnPoint = leftSpawn;
                direction = Vector3.right;
                break;

            case 1:
                spawnPoint = rightSpawn;
                direction = Vector3.left;
                break;

            case 2:
                spawnPoint = leftBackSpawn;
                direction = new Vector3(1, 0, -1);
                break;

            case 3:
                spawnPoint = rightBackSpawn;
                direction = new Vector3(-1, 0, -1);
                break;
        }

        int enemyType =
            Random.Range(0, enemyPrefabs.Length);

        GameObject enemy =
            Instantiate(
                enemyPrefabs[enemyType],
                spawnPoint.position,
                Quaternion.identity
            );


        enemy.GetComponent<EnemyMove>()
            .SetDirection(direction);
    }
}
