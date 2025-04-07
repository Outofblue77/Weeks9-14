using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkOnTray : MonoBehaviour
{
    public FoodOnTray foodOnTrayScript;  //Call score script to modify the value

    public GameObject burger;
    public GameObject drink;
    //Insert objects through unity
    void Start()
    {
        burger.SetActive(false);
        drink.SetActive(false);
        //Set objects to false to hide them from the screen
    }

    public void toggleFoodLeft() //Void to call on
    {
        if (drink.activeSelf)
        {
            drink.SetActive(false); //Turn off object
            foodOnTrayScript.leftFoodTrayItem = 0; //Make tray value back to 0
        }
        else
        {
            drink.SetActive(true);  //Turn on visual to show food has been selected
            burger.SetActive(false);  //hide other food incase it was already being displayed
            foodOnTrayScript.leftFoodTrayItem = 1; //Make tray value back to 0
        }
    }
}