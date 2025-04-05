using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriesOnTray : MonoBehaviour
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

    public void toggleFriesRight() //Void when uiImage is clicked on
    {
        if (fries.activeSelf) //Detect if fries object is active
        {
            fries.SetActive(false); //Turn off object 
        }
        else //Else meaning if the object is not active
        {
            fries.SetActive(true);     //Active Fries
            hotdog.SetActive(false);
            popcorn.SetActive(false);
            //Deactivated any other food that was selected
        }
    }
}
