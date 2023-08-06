using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] GameObject enemyFactory;
    float currentTime = 0;
    [SerializeField] float createTime = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime < createTime)
        {
            currentTime += Time.deltaTime;
        }
        else {
            GameObject ef = Instantiate(enemyFactory);
            ef.transform.position = transform.position;

            createTime = Random.Range(2f, 5f);
            currentTime = 0;
        }
    }
}
