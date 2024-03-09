using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D playerRigidbody;
    public float playerSpaceInput;
    public PlayerScore score;
    public bool Continue = true;
    public EnemySpawner enemySpawner;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && Continue == true){
            playerRigidbody.velocity = Vector2.up * playerSpaceInput;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        score.gameover();
        Continue = false;
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Reset"))
        {
            enemySpawner.SpawnEnemy();
        }
    }
}
