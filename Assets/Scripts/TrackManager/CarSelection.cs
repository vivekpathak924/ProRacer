using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSelection : MonoBehaviour
{
    private int CarColorSelect;
    [SerializeField] private GameObject RedCar;
    [SerializeField] private GameObject GreyCar;
    [SerializeField] private GameObject YellowwCar;
    [SerializeField] private GameObject PurpleCar;
    void Start()
    {
        CarColorSelect = CarManage.carType;

        if(CarColorSelect==1){
            RedCar.SetActive(true);
        }
        if(CarColorSelect==2){
            GreyCar.SetActive(true);
        }
        if(CarColorSelect==3){
            PurpleCar.SetActive(true);
        }
        if(CarColorSelect==4){
            YellowwCar.SetActive(true);
        }
    }

}
