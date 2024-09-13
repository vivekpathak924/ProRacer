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

}
