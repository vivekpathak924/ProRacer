using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class BestTime : MonoBehaviour
{

    public GameObject bestsecd;
    public GameObject bestmind;
    public GameObject bestmild;


    void OnTriggerEnter(){

        if(LapTimeManager.second <=9){
            bestsecd.GetComponent<Text>().text = "0" + LapTimeManager.second + ".";
        }
        else{
            bestsecd.GetComponent<Text>().text = ""+LapTimeManager.second + ".";
        }

        if(LapTimeManager.minute<=9){
            bestmind.GetComponent<Text>().text = "0" + LapTimeManager.minute + ":";
        }
        else{
            bestmind.GetComponent<Text>().text = "" + LapTimeManager.minute + ":";
            
        }
        bestmild.GetComponent<Text>().text = ""+ LapTimeManager.milli;

        PlayerPrefs.SetInt("MinSave",LapTimeManager.minute);
        PlayerPrefs.SetInt("SecSave",LapTimeManager.second);
        PlayerPrefs.SetFloat("MilliSave",LapTimeManager.milli);

    }
}
