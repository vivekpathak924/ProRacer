using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitWhenGameDone : MonoBehaviour
{
    // Start is called before the first frame update
    public void GameQuit(){
        Application.Quit();
        Debug.Log("Quit Game Done");
    }
}
