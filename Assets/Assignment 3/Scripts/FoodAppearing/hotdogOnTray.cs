using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hotdogOnTray : MonoBehaviour
{
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

    public void toggleHotdogRight() //Void when uiImage is clicked on
    {
        if (hotdog.activeSelf) //Detect if hotdog object is active
        {
            hotdog.SetActive(false); //Turn off object 
        }
        else //Else meaning if the object is not active
        {
            hotdog.SetActive(true);     //Activate hotdag :)
            fries.SetActive(false);
            popcorn.SetActive(false);
            //Deactivated any other food that was selected
        }
    }
}
