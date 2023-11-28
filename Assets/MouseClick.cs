using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Check for mouse buttons being pressed
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Left Click");
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Right Click");
        }

        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("Middle Click");
        }
    }
}
