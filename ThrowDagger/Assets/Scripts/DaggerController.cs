using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaggerController : MonoBehaviour
{
    public float rotationSpeed = 1000f;      
    public float throwSpeedMultiplier = 0.1f; 
    private Vector3 throwDirection;

    private Vector3 swipeStart;
    private Vector3 swipeEnd;

    void Update()
    {
        HandleSwipeInput();

        if (throwDirection != Vector3.zero)
        {
            transform.Rotate(0, 0, rotationSpeed);

            transform.Translate(throwDirection, Space.World);
        }
    }

    void HandleSwipeInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            swipeStart = Input.mousePosition;
            swipeStart.z = 0f;
            swipeStart = Camera.main.ScreenToWorldPoint(swipeStart);
        }

        if (Input.GetMouseButton(0))
        {
            swipeEnd = Input.mousePosition;
            swipeEnd.z = 0f; 
            swipeEnd = Camera.main.ScreenToWorldPoint(swipeEnd);

            Vector3 swipeDirection = swipeEnd - swipeStart;

            throwDirection = new Vector3(0, swipeDirection.y, 0);
        }

        if (Input.GetMouseButtonUp(0))
        {
            throwDirection = Vector3.zero;
        }
    }
}
