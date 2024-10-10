using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject EnemyPrefab;

    float elaspedTime;
    int rand;
    void Start()
    {
        elaspedTime = 0;
        rand = 0;
        if (EnemyPrefab)
        {
            GameObject clone = Instantiate(EnemyPrefab);
            clone.transform.position = transform.position;
            clone.transform.rotation = transform.rotation;
        }
    }

    void Update()
    {
        elaspedTime += Time.deltaTime;
        rand = Random.Range(0, 100);
        if(rand <70)
        {
            if (elaspedTime >= 10f)
            {
                if (EnemyPrefab)
                {
                    GameObject clone = Instantiate(EnemyPrefab);
                    clone.transform.position = transform.position;
                    clone.transform.rotation = transform.rotation;
                    elaspedTime = 0;
                }
            }
        }
        

    }
}
