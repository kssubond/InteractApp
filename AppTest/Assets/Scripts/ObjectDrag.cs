using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDrag : MonoBehaviour
{
    Vector3 mouseOffset;
    bool dragging = false;
    float mZCoord;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
            mouseOffset = gameObject.transform.position - GetMouseWorldPos();
            dragging = true;
        }
        if (Input.GetMouseButtonUp(1))
        {
            dragging = false;
        }

        if (dragging)
        {
            transform.position = GetMouseWorldPos() + mouseOffset;
        }
    }

    Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition; // pixel coordinates (x,y)
        mousePoint.z = mZCoord; // z coordinate of game object on screen
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
}
