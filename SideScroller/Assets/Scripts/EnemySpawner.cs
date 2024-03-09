using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    //public GameObject Enemy;
    public float spawnRate = 4;
    //private float timer = 0;
    public float enemyHeightOffset = 5;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemy();
    }
    public void SpawnEnemy()
    {
        float bottomPoint = transform.position.y - enemyHeightOffset;
        float topPoint = transform.position.y + enemyHeightOffset;

        float randomY = Random.Range(bottomPoint, topPoint);


        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, transform.position.z);

        //Instantiate(Enemy, new Vector3(transform.position.x, Random.Range(bottomPoint, topPoint), 0), transform.rotation);
        GameObject newEnemy = EnemyPool.instance.GetPool();
        if (newEnemy != null)
        {
            newEnemy.transform.position = spawnPosition;
            newEnemy.SetActive(true);
        }
    }
}
