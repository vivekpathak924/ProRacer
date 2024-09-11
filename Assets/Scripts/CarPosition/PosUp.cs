using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosUp : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private GameObject PositionUp;

    void OnTriggerExit(Collider other){
        if(other.CompareTag("PosCar")){
            PositionUp.GetComponent<Text>().text = "1st";
        }
    }
}
