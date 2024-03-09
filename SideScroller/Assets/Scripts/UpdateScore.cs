using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScore : MonoBehaviour
{
    //public PlayerScore score;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3){
            //score.addScore(1);
            PlayerScore.instance.addScore(1);
        }
    }
}
