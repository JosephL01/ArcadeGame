using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float enemySpeed = 5;
    public float deletionArea = -15;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * enemySpeed) * Time.deltaTime;

        if(transform.position.x < deletionArea)
        {
            gameObject.SetActive(false);
        }
    }
}
