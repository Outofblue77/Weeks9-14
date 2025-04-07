using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopcornOnTray : MonoBehaviour
{
    public FoodOnTray foodOnTrayScript;  //Call score script to modify the value

    public GameObject fries;
    public GameObject hotdog;
    public GameObject popcorn;
    //Creating gamobjects to reach from unity
    void Start()
    {
        fries.SetActive(false);
        hotdog.SetActive(false);
        popcorn.SetActive(false);
        //Set all objects to false so they are not showing
    }

    public void togglePopcornRight() //Void when uiImage is clicked on
    {
        if (popcorn.activeSelf) //Detect if popcorn object is active
        {
            popcorn.SetActive(false); //Turn off object 
            foodOnTrayScript.rightFoodTrayItem = 0; //Make tray value back to 0
        }
        else //Else meaning if the object is not active
        {
            popcorn.SetActive(true);     //Activate popcorn :)
            fries.SetActive(false);
            hotdog.SetActive(false);
            foodOnTrayScript.rightFoodTrayItem = 3; //Make tray value back to 0
            //Deactivated any other food that was selected
        }
    }
}
