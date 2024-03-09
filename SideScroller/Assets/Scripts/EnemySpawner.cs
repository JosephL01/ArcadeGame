using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject Enemy;
    public float spawnRate = 4;
    private float timer = 0;
    public float enemyHeightOffset = 5;

    // Start is called before the first frame update
    void Start()
    {
        spawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        //Allows the enemies to spawn without duplicating them a million times over.
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        } 
        else
        {
            spawnEnemy();
            timer = 0;
        }
    }

    void spawnEnemy()
    {
        float bottomPoint = transform.position.y - enemyHeightOffset;
        float topPoint = transform.position.y + enemyHeightOffset;

        Instantiate(Enemy, new Vector3(transform.position.x, Random.Range(bottomPoint, topPoint), 0), transform.rotation);
    }
}
