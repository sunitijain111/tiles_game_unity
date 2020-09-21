using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBehaviour : MonoBehaviour
{
    public void triggerMenuBehavior(int i)
  {
    switch(i)
   {
     default :
case(0):
 SceneManager.LoadScene("level1");
break;
case(1):
Application.Quit();
break;
   }
  }
}
