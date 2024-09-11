using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class tackManage : MonoBehaviour
{
    public GameObject carSelectScriptobject;
    public GameObject trackmanagescript;
    // Start is called before the first frame update
    public void ForestTrackPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        BGMmusic.instance.GetComponent<AudioSource>().Pause();
    }

    public void NoonTrackPressed(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
        BGMmusic.instance.GetComponent<AudioSource>().Pause();
    }

    public void NightTrackPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +3);
        BGMmusic.instance.GetComponent<AudioSource>().Pause();
    }

    public void MorningTrackPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +4);
        BGMmusic.instance.GetComponent<AudioSource>().Pause();
    }

    public void BackButtonPressed()
    {
        carSelectScriptobject.SetActive(true);
        trackmanagescript.SetActive(false);
    }
}
