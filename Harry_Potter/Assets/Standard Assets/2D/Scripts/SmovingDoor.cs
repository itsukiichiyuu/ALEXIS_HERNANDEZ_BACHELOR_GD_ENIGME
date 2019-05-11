using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmovingDoor : MonoBehaviour
{
  public bool open=false;
  void Update()
  {
    if ((PlayerPrefs.GetInt("open")==1) && (!open))
    {
      openDoor();
      open=true;
    }

  }
  public void openDoor()
  {
      GetComponent<Animator>().SetTrigger("upDoor");
  }
}
