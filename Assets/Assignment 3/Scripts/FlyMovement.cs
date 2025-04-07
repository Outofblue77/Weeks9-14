using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class FlyMovement : MonoBehaviour
{
    public CheckingAnswer scoreModifier; //Call script to adjust score mechanics

    public PlayerScore score;   //Call score script to modify it

    public bool flyClicked; //Bool to detect if play has swat the fly

    public float flyingSpeed;       //Adjust speed
    public float flyingDestination; //Adjust endlocation of fly

    public Vector3 originalPosition;
    void Start()
    {
        originalPosition = transform.position;
        flyClicked = false;
        flyingSpeed = 350f;
        flyingDestination = -450;
        //Settting all paramters for creates statements
    }

    public void wrongOrder ()
    {
        flyClicked = false; //Begin fly without being clicked each time
        StartCoroutine(FlyBeginFlying());   //Start fly courotine
    }

    public IEnumerator FlyBeginFlying() //Coroutine for fly movement
    {
        while (transform.position.x > flyingDestination && !flyClicked)
        {
            transform.Translate(Vector3.left * flyingSpeed * Time.deltaTime); //Move fly 
            yield return null;
        }
        if (flyClicked) //Clicked Event
        {
            transform.position = originalPosition; //Set fly back to starting position off screen
            score.value += 20; //Give some score to the player
        }
        else //Fly Reached other side event
        {
            scoreModifier.addedScore -= 10; //Reduce points player can get from now on
            score.value -= 50; //Remove player points for letting the fly pass by
            transform.position = originalPosition; //Move fly back to its origin
        }

    }

    public void flyHasBeenClicked()
    {
        flyClicked = true; //Set the fly has been clicked
    }


}
