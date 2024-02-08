using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnobMove : MonoBehaviour
{
    public float Speed = 10f;
    private bool IsRotating = false;
    private float startMousePos;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            IsRotating = true;
            startMousePos = Input.mousePosition.x;
        }
        
        else if (Input.GetMouseButtonUp(0))
        {
            IsRotating = false;
        }

        if (IsRotating)
        {
            float currentMousePos = Input.mousePosition.x;
            float mouseMovement = currentMousePos - startMousePos;
            
            transform.Rotate(Vector3.up, -mouseMovement * Speed * Time.deltaTime);
            startMousePos = currentMousePos;
        }
        
    }
}
