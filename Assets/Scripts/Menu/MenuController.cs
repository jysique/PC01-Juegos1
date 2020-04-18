using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    public Button btnPlay;
    public Button btnOptions;
    
    void Start()
    {
        btnPlay.onClick.AddListener(()=>goGame());
        btnOptions.onClick.AddListener(()=>goAbout());
    }
    void Update()
    {
        
    }
    public void goGame(){
        SceneManager.LoadScene("Game");
        
    }
    public void goAbout(){
        SceneManager.LoadScene("GameOver");
        
    }
}
