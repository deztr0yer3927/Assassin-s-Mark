﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // horizontal rotation speed
    public float horizontalSpeed = 1f;
    // vertical rotation speed
    public float verticalSpeed = 1f;
    private float xRotation = 0.0f;
    private float yRotation = 0.0f;
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
        
        Cursor.visible = false;

        Screen.lockCursor = true;

    }

    // Update is called once per frame
    void Update()
    {
    
        
        float mouseX = Input.GetAxis("Mouse X") * horizontalSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * verticalSpeed;
 
        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
 
        cam.transform.eulerAngles = new Vector3(xRotation, yRotation, 0.0f);
        
        if (Input.GetKey(KeyCode.E))
        {
            Cursor.visible = true;
            Screen.lockCursor = false;
        }
        
        

    

  
    }
}
