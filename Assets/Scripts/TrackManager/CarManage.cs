using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CarManage : MonoBehaviour
{
    public GameObject trackselectpanellobject;
    public GameObject carselectpanellobject;
    public static int carType = 0;  
    public void RedCarPressed()
    {
        trackselectpanellobject.SetActive(true);
        carselectpanellobject.SetActive(false);
        carType = 1;  
    }

    public void GreyCarPressed(){
        trackselectpanellobject.SetActive(true);
        carselectpanellobject.SetActive(false);
        carType = 2; 
    }

    public void PurpleCarPressed()
    {
        trackselectpanellobject.SetActive(true);
        carselectpanellobject.SetActive(false);
        carType = 3; 
    }

    public void YellowCarPressed()
    {
        trackselectpanellobject.SetActive(true);
        carselectpanellobject.SetActive(false);
        carType = 4; 
    }

    public void BackButtoPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }

}
