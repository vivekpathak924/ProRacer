using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class forEveryLevelMusic : MonoBehaviour
{
    public static forEveryLevelMusic instance;

    void Start(){
        instance = this;
    }
    void Update()
    {
        if(instance==null){
            Destroy(gameObject);
        }
    }
}
