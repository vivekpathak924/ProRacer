using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosDown : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private GameObject PositionDown;

    void OnTriggerExit(Collider other){
        if(other.CompareTag("PosCar")){
            PositionDown.GetComponent<Text>().text = "2nd";
        }
    }
}
