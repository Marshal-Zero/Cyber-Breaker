using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {
        float xMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;

        Vector3 currentPosition = transform.position;

        currentPosition.x = xMousePosition;

        transform.position = currentPosition;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -6.91f, 6.91f), transform.position.y, transform.position.z);             
       
    }
}
