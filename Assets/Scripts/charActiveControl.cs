using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class charActiveControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject charActivePlayer;
    public GameObject dreamCar;
    void Start()
    {
        charActivePlayer.GetComponent<CarUserControl>().enabled = true;
        charActivePlayer.GetComponent<TrailPowerUps>().enabled = true;
        dreamCar.GetComponent<CarAIControl>().enabled = true;
    }

    // Update is called once per frame
}
