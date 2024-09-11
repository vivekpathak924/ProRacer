using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LapTimeManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static int minute;
    public static int second;
    public static float milli;
    public static string millidisplay;

    public GameObject mind;
    public GameObject secd;
    public GameObject mild;
    
    void Start(){
        minute = 0;
        second = 0;
        milli = 0;
        mild.GetComponent<Text>().text = ""+millidisplay;
        secd.GetComponent<Text>().text = "0" + second + ".";
        mind.GetComponent<Text>().text = "0" + minute + ":";
    }
    void Update()
    {
        milli += Time.deltaTime * 10;
        millidisplay = milli.ToString("F0");
        mild.GetComponent<Text>().text = ""+millidisplay;

        if(milli>=10){
            milli = 0;
            second += 1; 
        }
        if(second <=9){
            secd.GetComponent<Text>().text = "0" + second + ".";
        }
        else{
            secd.GetComponent<Text>().text = ""+second + ".";
        }

        if(second>=60){
            second = 0;
            minute += 1;
        }
        if(minute<=9){
            mind.GetComponent<Text>().text = "0" + minute + ":";
        }
        else{
            mind.GetComponent<Text>().text = "" + minute + ":";
        }
    }
}
