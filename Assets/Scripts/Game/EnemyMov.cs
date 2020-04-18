using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMov : MonoBehaviour
{
    private BoxCollider2D collider;
    private Rigidbody2D body;
    public float speed;
    void Start()
    {
        
        collider = GetComponent<BoxCollider2D>();
        body = GetComponent<Rigidbody2D>();
        
        speed =speed ==0? -2:speed;
    }

    // Update is called once per frame
    void Update()
    {
        body.velocity = new Vector2(speed,0.0f);
    }
}
