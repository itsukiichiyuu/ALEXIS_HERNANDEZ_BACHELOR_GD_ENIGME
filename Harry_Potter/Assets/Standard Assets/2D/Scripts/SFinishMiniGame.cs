using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SFinishMiniGame : MonoBehaviour
{
    void ExitMiniGame()
    {
        SceneManager.UnloadSceneAsync ("minijeu");
    }
    void ReloadMiniGame()
    {
        SceneManager.UnloadSceneAsync ("minijeu");
    }

}
