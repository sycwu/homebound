using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    private float startPosX;
    private float startPosY;
    private bool isBeingHeld = false;

    // Update is called once per frame
    void Update()
    {
        if(isBeingHeld == true) 
        {
            Vector3 mousePos; //makes a vector3
            mousePos = Input.mousePosition; //sets it equal to position of mouse 
            mousePos = Camera.main.ScreenToWorldPoint(mousePos); //makes sure that the mouse position we track is only inside the game screen
            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, 0);
        }
    }

    public void OnMouseDown()
    {
        Debug.Log("hiya");
        if (Input.GetMouseButtonDown(0)) //0 is left mouse button 
        {
            Debug.Log("hi");
            Vector3 mousePos; //makes a vector3
            mousePos = Input.mousePosition; //sets it equal to position of mouse 
            mousePos = Camera.main.ScreenToWorldPoint(mousePos); //makes sure that the mouse position we track is only inside the game screen
            startPosX = mousePos.x - this.transform.localPosition.x; //takes the difference between the center of the piece to the mouse position (without this, it immediately moves the piece so that the center is at mouse position even if we clicked on the corner)
            startPosY = mousePos.y - this.transform.localPosition.y;
            isBeingHeld = true;
        }

    }

    public void OnMouseUp()
    {
        isBeingHeld = false;
    }

}
