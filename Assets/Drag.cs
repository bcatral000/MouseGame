using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    //variables for the game
    float startPosx;    // start position on the x-axis
    float startPosy;    // start position on the y-axis
    bool isBeingHeld;   // determine if object is being held
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isBeingHeld)
        {
            Vector2 mousePos;   //create vector two called mousePos
            mousePos = Input.mousePosition;     //change the value of mousePos
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);    //change position of the 
            gameObject.transform.localPosition = new Vector2(mousePos.x,mousePos.y);
        }    
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            isBeingHeld = true;
        }
        
    }

    void OnMouseUp()
    {
        isBeingHeld = false;
    }
    

}
