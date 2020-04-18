using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float timeElapse =0f;
    public List<GameObject> elements = new List<GameObject>();
    public float movementInst= 10.0f;
    private float startX = 8;
    private float generationTime = 4f;

    //private float scoreTime= 0f ;
    //private int lives = 4;
    public  List<GameObject> pool = new List<GameObject>();
    void Start()
    {
        generatePoolObjects();
    }

    // Update is called once per frame
    void Update()
    {
        //scoreTime += Time.deltaTime;
        //txtScore.text = "SCORE: " + scoreTime.ToString("0");
    
        timeElapse +=  Time.deltaTime;
        if (timeElapse >generationTime)
        {
            timeElapse = 0;
            GetFirstDead();
        }
    }
    void generatePoolObjects(){
        int scale = 1;
        for (int i = 0; i < elements.Count; i++)
        {
            for (int j = 0; j < elements.Count; j++)
            {
                GameObject ga =Instantiate(elements[i],new Vector3(startX,0.0f,-3.0f),Quaternion.identity);
                scale = ga.tag == "Enemy"? 1: -1;
                ga.transform.localScale = new Vector3(0.5f*scale,0.5f,1);
                ga.SetActive(false);
                pool.Add(ga);
            }
        }
    }
    void GetFirstDead(){
        //print("getFirstDead");
        //while(true){
            int index  = Random.Range(0,pool.Count);
            if(!pool[index].activeInHierarchy){
                //print("become active");
                pool[index].SetActive(true);
                pool[index].transform.position = new Vector3(transform.position.x, transform.position.y,0);
                //break;
            }else{
                index  = Random.Range(0,pool.Count);
            }
      //  }
    // */
    }
}
