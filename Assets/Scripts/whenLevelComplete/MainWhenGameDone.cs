using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainWhenGameDone : MonoBehaviour
{
    // Start is called before the first frame update
    public void mainMenuPressedUp(){
        SceneManager.LoadScene(0);
        BGMmusic.instance.GetComponent<AudioSource>().Play();
        Time.timeScale = 1;
    }
    
}
