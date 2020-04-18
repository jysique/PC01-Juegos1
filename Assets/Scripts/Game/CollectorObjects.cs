using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorObjects : MonoBehaviour
{
    private BoxCollider2D collider2D;
    private List<string> tags = new List<string>(){"Enemy0","Enemy1","Enemy2","Enemy3","Enemy4"};
    // Start is called before the first frame update
    void Start()
    {
        collider2D = GetComponent<BoxCollider2D>();
        collider2D.isTrigger = true;
    }
    void OnTriggerEnter2D(Collider2D other){
        
        GameObject ga = other.gameObject;
        if (tags.IndexOf(ga.tag)>-1)
        {
            ga.SetActive(false);
        }
    }

}
