using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayButtonPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitBottonPressed()
    {
        Application.Quit();
        Debug.Log("Quit Button Presses");
    }
}
