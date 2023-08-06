using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    [SerializeField] Material bgMaterial;
    [SerializeField] float speed = 0.2f;

   
    void Update()
    {
        Vector2 dir = Vector2.up;
        bgMaterial.mainTextureOffset += dir * speed *Time.deltaTime;
    }
}
