using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    Vector3 dir;
    [SerializeField] GameObject explosionFactory;
    void Start()
    {
        // make RandomNum
        int randomNum = Random.Range(0,10);

        if(randomNum < 3 )
        {
            //find Player
            GameObject player = GameObject.Find("Player");
            //move by player
            dir = player.transform.position - transform.position;
            dir.Normalize();
        }
        else
        {
            dir = Vector3.down;
        }
       
    }
    void Update()
    {
        transform.position = transform.position + dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject explosion =Instantiate(explosionFactory);
        explosion.transform.position = transform.position;
        if (collision.gameObject.GetComponent<Bullet>())
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
