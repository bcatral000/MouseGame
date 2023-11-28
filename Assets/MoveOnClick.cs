using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOnClick : MonoBehaviour
{
    //variables for the game
    public float speed = 10f;       //control the speed of movement

    Vector2 lastMousePos;            //store the position of the mouse
    
    bool moving;                    //beep track of movement

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //change the value of 
            moving = true;
        }  

        if (moving && (Vector2)transform.position != lastMousePos)
        {
            float step = speed * Time.deltaTime;     //create variable for the movement
            transform.position = Vector2.MoveTowards(transform.position, lastMousePos, step);   //move
        }

        else
        {
            moving = false;
        }
    }
}
