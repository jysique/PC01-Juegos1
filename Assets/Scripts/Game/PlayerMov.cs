using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    private float speed = 8.0f;

    private float maxVelocity = 4f;
    // Start is called before the first frame update
    private Rigidbody2D body2D;
    private float minY, maxY;
    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
        SetMinAndMax();
    }

    private void FixedUpdate() {
        //Fisicas
        PlayerWalkKeyBoard();
    }
    void SetMinAndMax(){
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,0));
        minY = -bounds.y;
        maxY = bounds.y;
    }
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < minY)
        {
            Vector2 temp = transform.position;
            temp.y = minY;
            transform.position = temp;
        }if (transform.position.y > maxY)
        {            
            Vector2 temp = transform.position;
            temp.y = maxY;
            transform.position = temp;
        }
        
    }
    void PlayerWalkKeyBoard(){
        float forceY = 0f;
        float vel = Mathf.Abs(body2D.velocity.y);
        /*
        GetAxis: Del -1 al 1
        GetAxisRaw: -1,0 o 1
        */
        float h = Input.GetAxisRaw("Vertical");
        if (h>0)
        {
            if (vel < maxVelocity)
            {
                forceY = speed;
            }
            Vector3 temp = transform.localScale;
            //temp.y = 1f;
            transform.localScale = temp;
            //animator.SetBool("isWalking",true);
        }
        else if (h< 0)
        {
            if (vel < maxVelocity)
            {
                forceY = -speed;
            }
            Vector3 temp = transform.localScale;
            //temp.y = -1f;
            transform.localScale = temp;
            //animator.SetBool("isWalking",true);
        }else{
            //animator.SetBool("isWalking",false);
            body2D.velocity = Vector2.zero;
        }
        body2D.AddForce(new Vector2(0,forceY));
    }
}
