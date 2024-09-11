using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Vehicles.Car;
public class pauseMenuscript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pauseMenuPanel;

    // public static bool isPaused;
    // [SerializeField]private AudioSource first;
    // [SerializeField]private AudioSource second;
    // [SerializeField]private AudioSource third;
    // [SerializeField]private AudioSource forth;
    
    public void PauseButtonPressed(){
        pauseMenuPanel.SetActive(true);
        CarAudio.m_LowAccel.Pause();
        CarAudio.m_HighAccel.Pause();
        CarAudio.m_HighDecel.Pause();
        CarAudio.m_LowDecel.Pause();
        CarAIAudio.ai_HighAccel.Pause();
        CarAIAudio.ai_HighDecel.Pause();
        CarAIAudio.ai_LowAccel.Pause();
        CarAIAudio.ai_LowDecel.Pause();
        // first.Pause();
        // second.Pause();
        // third.Pause();
        // forth.Pause();
        // isPaused = true;
        Time.timeScale = 0;
    }
    public void ResumeButtonPressed(){
        pauseMenuPanel.SetActive(false);
        CarAudio.m_LowDecel.Play();
        CarAudio.m_LowAccel.Play();
        CarAudio.m_HighAccel.Play();
        CarAudio.m_HighDecel.Play();
        CarAIAudio.ai_HighAccel.Play();
        CarAIAudio.ai_HighDecel.Play();
        CarAIAudio.ai_LowAccel.Play();
        CarAIAudio.ai_LowDecel.Play();
        // isPaused = false;
        Time.timeScale = 1;
    }

    public void CutButtonPressed(){
        pauseMenuPanel.SetActive(false);
        CarAudio.m_LowDecel.Play();
        CarAudio.m_LowAccel.Play();
        CarAudio.m_HighAccel.Play();
        CarAudio.m_HighDecel.Play();
        CarAIAudio.ai_HighAccel.Play();
        CarAIAudio.ai_HighDecel.Play();
        CarAIAudio.ai_LowAccel.Play();
        CarAIAudio.ai_LowDecel.Play();
        // isPaused = false;
        Time.timeScale = 1;
    }

    public void RestartButtonPressed(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
        Time.timeScale = 1;
    }

    public void mainMenuPressed(){
        SceneManager.LoadScene("MenuBar");
        BGMmusic.instance.GetComponent<AudioSource>().Play();
        Time.timeScale = 1;
    }
    public void Exit(){
        Application.Quit();
        Debug.Log("Quit Game Done");
    }
}
