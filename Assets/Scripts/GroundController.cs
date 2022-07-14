using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    private float xBoundary = 2.5f;
    [SerializeField] private float groundSpeed;    
    private void Update()
    {
        ControlPosition();
        GroundMove();        
    }

    private void GroundMove()
    {
        transform.Translate(-groundSpeed*Time.deltaTime, 0, 0);
    }

    private void ControlPosition()
    {
        if (transform.position.x <= -xBoundary)
        {            
            transform.position = new Vector2(xBoundary, transform.position.y);
        }
    }
}
