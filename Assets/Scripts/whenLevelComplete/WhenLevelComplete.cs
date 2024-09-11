using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WhenLevelComplete : MonoBehaviour
{

    public void RetryButtonPressed(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
        Time.timeScale = 1;
    }

    public void mainMenuPressedUp(){
        SceneManager.LoadScene(0);
        BGMmusic.instance.GetComponent<AudioSource>().Play();
        Time.timeScale = 1;
    }
    private void GameQuit(){
        Application.Quit();
        Debug.Log("Quit Game Done");
    }
}
