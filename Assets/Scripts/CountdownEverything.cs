using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;
public class CountdownEverything : MonoBehaviour
{
    public GameObject countdown;
    public GameObject LapTimer;
    public GameObject charControl;

    public AudioSource audioclip;
    public AudioSource audioclip2;
    public AudioSource LevelMusic;

    public GameObject togglecam;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (CountStart());
    }

    // Update is called once per frame
    IEnumerator CountStart(){
        yield return new WaitForSeconds(0.5f);
        countdown.GetComponent<Text>().text = "3";
        audioclip.Play();
        countdown.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        countdown.SetActive(false);
        countdown.GetComponent<Text>().text = "2";
        audioclip.Play();
        countdown.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        countdown.SetActive(false);
        countdown.GetComponent<Text>().text = "1";
        audioclip.Play();
        countdown.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        countdown.SetActive(false);
        audioclip2.Play();
        LapTimer.SetActive(true);
        charControl.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        LevelMusic.Play();
        yield return new WaitForSeconds(5);
        togglecam.GetComponent<Text>().enabled = true;
        yield return new WaitForSeconds(3);
        togglecam.GetComponent<Text>().enabled = false;
    }
}
