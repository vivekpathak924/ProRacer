using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour
{
    public int minute;
    public int second;
    public float milli;

    public GameObject mindisplay;
    public GameObject secdisplay;
    public GameObject millidisplay;
    void Start()
    {
        minute = PlayerPrefs.GetInt("MinSave");
        second = PlayerPrefs.GetInt("SecSave");
        milli = PlayerPrefs.GetFloat("MilliSave");

        if(minute<10)
            mindisplay.GetComponent<Text>().text = "0" + minute + ":";
        else
            mindisplay.GetComponent<Text>().text = "" + minute + ":";
        if(second<10)
            secdisplay.GetComponent<Text>().text = "0" + second + ".";
        else
            secdisplay.GetComponent<Text>().text = "" + second + ".";
        millidisplay.GetComponent<Text>().text = "" + milli;
    }

}
