using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfActDeact : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject FullLap;
    public GameObject HalfLap;

    void OnTriggerEnter(){
        FullLap.SetActive(true);
        HalfLap.SetActive(false);
    } 
}
