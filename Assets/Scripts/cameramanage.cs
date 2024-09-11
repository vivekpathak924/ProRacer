using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramanage : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cameraactive;
    public GameObject camera2active;
    // Update is called once per frame
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C)){
            cameraactive.SetActive(false);
            camera2active.SetActive(true);
        }
        if(Input.GetKeyUp(KeyCode.C)){
            cameraactive.SetActive(true);
            camera2active.SetActive(false);
        }
    }
}
