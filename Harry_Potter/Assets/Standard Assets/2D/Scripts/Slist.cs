using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slist : MonoBehaviour
{
    public GameObject[] objList;

    public void setVoisinToFalse()
    {
        for (int i = 0; i < objList.Length; i++)
        {
            objList[i].GetComponent<SCheckPoint>().voisin=false;
        }
    }
}
