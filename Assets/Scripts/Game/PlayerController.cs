using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerController : MonoBehaviour
{
    private int lives = 4;
    /*
    private void OnCollisionEnter2D(Collision2D other) {
    if (other.gameObject.tag == "Enemy0" || other.gameObject.tag == "Enemy1" || other.gameObject.tag == "Enemy2" || other.gameObject.tag == "Enemy3" || other.gameObject.tag == "Enemy4")
    {
            print("Hola1");
        }
    }
    */
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Enemy0")
        {
            Debug.Log(lives);
        }else if (other.gameObject.tag == "Enemy1")
        {
            lives-=3;
            Debug.Log(lives);
        }else if (other.gameObject.tag == "Enemy2")
        {
            lives=0;
            Debug.Log(lives);
        }else if (other.gameObject.tag == "Enemy3")
        {
            lives+=2;
            Debug.Log(lives);
        }else if (other.gameObject.tag == "Enemy4")
        {
            lives-=1;
            Debug.Log(lives);
        }
    }
    private void Update() {
        //Debug.Log(lives);
        if (lives==0)
        {
            GameOver();
        }
    }

    void GameOver(){
        SceneManager.LoadScene("GameOver");
    }
}
