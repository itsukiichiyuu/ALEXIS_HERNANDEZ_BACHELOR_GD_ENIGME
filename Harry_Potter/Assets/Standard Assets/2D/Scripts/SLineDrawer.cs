using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SLineDrawer : MonoBehaviour {
  private LineRenderer lineR;
  private Vector3 mousePosition;

  [HideInInspector] public Vector3[] traceComplet;

  void Awake()
  {
    lineR = GetComponent<LineRenderer>();
  }

  public void setArray(Vector3 newTransform){ //ajout d'un élément à l'array

    lineR.positionCount++;
    Vector3[] traceTemp = new Vector3[traceComplet.Length+1];
    for (int i=0;i<traceComplet.Length;i++)
    {
      traceTemp[i]=traceComplet[i];
    }
    traceTemp[traceComplet.Length]=newTransform;//on place en avant dernier le transform ajouté,en dernier ce sera la souris
    traceComplet=traceTemp;

    for (int i=0; i<traceComplet.Length;i++)
    {
      lineR.SetPosition(i,traceComplet[i]);
    }
  }

  //AJOUT D'UNE FONCTION QUI DETECTE SI LE JOUEUR A FINIT OU PAS (si le dernier click est à l'arrivée)
  //enabled = false; //stop le script
}