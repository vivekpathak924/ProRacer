using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityStandardAssets.Vehicles.Car;

public class TrailPowerUps : MonoBehaviour
{
    public float activeTime;
    [SerializeField]private GameObject NitroParent;

    void OnTriggerEnter(Collider col){
        if(col.gameObject.CompareTag("SmallPower")){
            activeTime = 2f;
            Destroy(col.transform.parent.gameObject);
            StartCoroutine(ActivePowerUps(activeTime));
            GetComponent<CarController>().ApplyNitroBoost(1000000f,activeTime);
        }
        if(col.gameObject.CompareTag("MidPower")){
            activeTime = 4f;
            Destroy(col.transform.parent.gameObject);
            StartCoroutine(ActivePowerUps(activeTime));
            GetComponent<CarController>().ApplyNitroBoost(1000000f,activeTime);
        }
        if(col.gameObject.CompareTag("BigPower")){
            activeTime = 6f;
            Destroy(col.transform.parent.gameObject);
            StartCoroutine(ActivePowerUps(activeTime));
            GetComponent<CarController>().ApplyNitroBoost(1000000f,activeTime);
        }
    }

    IEnumerator ActivePowerUps(float activeTime){
        NitroParent.SetActive(true);
        yield return new WaitForSeconds(activeTime);
        NitroParent.SetActive(false);
    }
}
