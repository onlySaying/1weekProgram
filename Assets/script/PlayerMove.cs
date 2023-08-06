using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//player move in the game
//if users should input action, object will be move 
public class PlayerMove : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    void Start()
    {
        
    }
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(h, v, 0);
        dir.Normalize();
        transform.position = transform.localPosition + dir * speed * Time.deltaTime;
    }
}
