using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScaler : MonoBehaviour
{
    private float height;
    private float width;
    void Start()
    {
        height = Camera.main.orthographicSize *2.0f; //alto de la camara. 
        width = height*Screen.width /Screen.height;
        if (gameObject.name == "BackGround")
        {
            transform.position = new Vector3(0,0,1);
            transform.localScale = new Vector3(width,height,1);
        }else{
            transform.position = new Vector3(0,-4.5f,-2);
            transform.localScale = new Vector3(width +10f,4,1);
        }
    }
}
