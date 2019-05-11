using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SStartMiniGame : MonoBehaviour
{
    private bool open=false;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag=="Player" && !open)
        open=true;
        SceneManager.LoadSceneAsync("minijeu",LoadSceneMode.Additive);
    }
    private void OnTriggerExit2D(Collider2D other) 
    {
        open=false;
        SceneManager.UnloadSceneAsync("minijeu");
    }  
}
