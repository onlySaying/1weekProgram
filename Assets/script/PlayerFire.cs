using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//shoot the bullet
//if u click fire button
public class PlayerFire : MonoBehaviour
{
    //create object 
    [SerializeField] GameObject bulletFactory;
    [SerializeField] GameObject firePosition;

    // 데이터 파편화 방지
    [SerializeField] GameObject[] bulletArray;
    void Start()
    {
        bulletArray = new GameObject[10];
        for(int i = 0; i < bulletArray.Length; i++) 
        {
            GameObject go = Instantiate(bulletFactory);
            bulletArray[i] = go;
            bulletArray[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           //GameObject bf = Instantiate(bulletFactory);
           //bf.transform.position = firePosition.transform.position;
           for(int i =0; i < bulletArray.Length; i++) 
           {
                if (bulletArray[i] != null)
                {
                    if (!bulletArray[i].activeSelf)
                    {
                        bulletArray[i].transform.position = firePosition.transform.position;
                        bulletArray[i].SetActive(true);
                        break;
                    }
                }
                else 
                {
                    GameObject go = Instantiate(bulletFactory);
                    bulletArray[i] = go;
                }
                
           }
        }
    }
}
