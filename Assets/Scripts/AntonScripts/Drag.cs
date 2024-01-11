using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    private bool dragging = false;
    private Vector3 offset;

   
   
    public BoxCollider2D area;

    
    

    private void Start()
    {
        GameObject Background = GameObject.FindWithTag("area");

        area = Background.GetComponent<BoxCollider2D>();


    }

    // Update is called once per frame
    void Update()
    {
        if (dragging)
        {
            //Move object and set the center of object where mouse clicked
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }
    }

    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;
    }

    private void OnMouseUp()
    {
       
        dragging = false;//Stop dragging
    }
    
       
        // called after Update, before rendering
        private void LateUpdate()
        {
            // get the current position
            Vector3 clampedPosition = transform.position;
            // limit the x and y positions to be between the area's min and max x and y.
            clampedPosition.x = Mathf.Clamp(clampedPosition.x, area.bounds.min.x, area.bounds.max.x);
            clampedPosition.y = Mathf.Clamp(clampedPosition.y, area.bounds.min.y, area.bounds.max.y);
           
            // apply the clamped position
            transform.position = clampedPosition;
        }
    
}
