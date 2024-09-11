using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class GameOver : MonoBehaviour
{
    
    [SerializeField]private GameObject WinPanel;
    [SerializeField]private GameObject LosePanel;
    [SerializeField]private GameObject PauseButton;
    void OnTriggerEnter(Collider other){

        PauseButton.SetActive(false);
        CarAudio.m_LowAccel.Stop();
        CarAudio.m_HighAccel.Stop();
        CarAudio.m_HighDecel.Stop();
        CarAudio.m_LowDecel.Stop();
        CarAIAudio.ai_HighAccel.Stop();
        CarAIAudio.ai_HighDecel.Stop();
        CarAIAudio.ai_LowAccel.Stop();
        CarAIAudio.ai_LowDecel.Stop();
        FindObjectOfType<WheelEffects>().StopAudio();
        
        if(!other.CompareTag("Player")){
            LosePanel.SetActive(true);
            forEveryLevelMusic.instance = null;
            Time.timeScale = 0;
        }

        if(other.CompareTag("Player")){
            WinPanel.SetActive(true);
            forEveryLevelMusic.instance = null;
            Time.timeScale = 0;
        }
  
    }
}
