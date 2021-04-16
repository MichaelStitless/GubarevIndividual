﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform[] target;  
    public bool platformRotationNormalized;
    public float speed;  
    private int current; 

    // Use this for initialization    
    void Start()
    {
        speed = 3f;
        //platformRotationNormalized
    }  

    // Update is called once per frame    
    void Update() 
    {  
        if (transform.position != target[current].position) 
        {  
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);  
            GetComponent < Rigidbody > ().MovePosition(pos);  
        } 
        else current = (current + 1) % target.Length;  
    }  
}