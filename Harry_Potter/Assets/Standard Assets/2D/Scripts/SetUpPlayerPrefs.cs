using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUpPlayerPrefs : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetInt("open",0);
    }
}
