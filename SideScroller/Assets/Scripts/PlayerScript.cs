using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D playerRigidbody;
    public float playerSpaceInput;
    public PlayerScore score;
    public bool Continue = true;

    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<PlayerScore>();
    }

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
}
