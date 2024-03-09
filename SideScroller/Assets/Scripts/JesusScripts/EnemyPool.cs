using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour
{
    public static EnemyPool instance;
    private List<GameObject> pooledObjects = new List<GameObject>();
    private int poolSize = 20;
    [SerializeField] private GameObject laserPrefab;
    // Start is called before the first frame update

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        StartPool();
    }

    public GameObject GetPool()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }

        return null;
    }

    public void StartPool()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject newEnemy = Instantiate(laserPrefab);
            newEnemy.SetActive(false);
            pooledObjects.Add(newEnemy);
        }
    }
}
