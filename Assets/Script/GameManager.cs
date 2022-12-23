using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void Start()
    {
        Cursor.visible = true;

    }
    public void Startgame()
    {
        Application.LoadLevel("SampleScene");
        Time.timeScale = 1;
    }
    public void Mainmenu()
    {
        Time.timeScale = 1;
        Application.LoadLevel("MainMenu");
    }
    /* public void Reset()
     {

     }*/
}
