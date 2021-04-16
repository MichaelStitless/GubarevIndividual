using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformRotation : MonoBehaviour
{
    
    public GameObject platform;
    void Update() 
    {
        if(Input.touchCount == 1)
        {            
            Touch touchZero = Input.GetTouch(0);  
            if(touchZero.phase == TouchPhase.Began)
            {
                platform.transform.rotation = Quaternion.identity;
            }                
        }    
    }
}