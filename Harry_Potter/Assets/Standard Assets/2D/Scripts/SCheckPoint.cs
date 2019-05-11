using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCheckPoint : MonoBehaviour
{
    private GameObject drawer;
    public GameObject check;
    public bool isStarter=false;
    public bool isLast=false;
    [HideInInspector] public bool voisin=false;
    public GameObject[] objVoisin;

    private void Start() 
    {
        if (isStarter)
        {
            voisin=true;
            OnMouseEnter();
        }
    }

    //quand la souris passe au dessus, il ajoute sa position à la liste d'array du LineDrawer
    private void OnMouseEnter() 
    {
        if (voisin)
        {
            //passe tout les checkPoints sur voisin=false
            GameObject.Find("checkPointList").GetComponent<Slist>().setVoisinToFalse();

            //passe les bons checkPoint sur voisin=true
            setVoisinToTrue();

            //récupère le lineDrawer
            drawer=GameObject.Find("lineDrawer");

            //ajoute la position du checkpoint actuel comme point dans la liste des ligne à tracer
            drawer.GetComponent<SLineDrawer>().setArray(transform.position);

            if (isLast)
            {
                PlayerPrefs.SetInt("open",1);
            }
            //désactive le gameObject (ne fonctionne pas)
            //enabled = false;

            //désactive le script
            check.GetComponent<BoxCollider2D>().enabled=false;
        }

    }

    public void setVoisinToTrue()
    {
        for (int i = 0; i < objVoisin.Length; i++)
        {
            objVoisin[i].GetComponent<SCheckPoint>().voisin=true;
        }
    }
}
