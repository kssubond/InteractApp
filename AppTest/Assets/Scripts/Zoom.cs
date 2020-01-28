﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    public float zoomSpeed;
    public float orthographicSizeMin;
    public float orthographicSizeMax;
    public float fovMin;
    public float fovMax;

    Camera myCamera;
    void Start()
    {
        myCamera = GetComponent<Camera>();
    }
    void Update()
    {
        if (myCamera.orthographic)
        {
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                myCamera.orthographicSize += zoomSpeed;
            }
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                myCamera.orthographicSize -= zoomSpeed;
            }
            myCamera.orthographicSize = Mathf.Clamp(myCamera.orthographicSize, orthographicSizeMin, orthographicSizeMax);
        }
        else
        {
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                myCamera.fieldOfView += zoomSpeed;
            }
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                myCamera.fieldOfView -= zoomSpeed;
            }
            myCamera.fieldOfView = Mathf.Clamp(myCamera.fieldOfView, fovMin, fovMax);
        }
    }
}
