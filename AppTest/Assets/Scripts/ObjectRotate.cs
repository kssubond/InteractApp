using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotate : MonoBehaviour
{
    float sensitivity;
    Vector3 mouseRef;
    Vector3 mouseOffset;
    Vector3 rotation;
    bool isRotating;

    void Start()
    {
        sensitivity = 0.1f;
        rotation = Vector3.zero;
    }

    void Update()
    {
        if(isRotating)
        {
            mouseOffset = (Input.mousePosition - mouseRef);
            rotation.y = -(mouseOffset.x + mouseOffset.y) * sensitivity;
            rotation.x = (mouseOffset.y - mouseOffset.x) * sensitivity;
            transform.Rotate(rotation);
            mouseRef = Input.mousePosition;
        }
    }

    void OnMouseDown()
    {
        isRotating = true;
        mouseRef = Input.mousePosition;
    }

    void OnMouseUp()
    {
        isRotating = false;
    }
}
