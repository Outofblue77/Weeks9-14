using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodAppearing : MonoBehaviour
{
    public FoodOnTray foodOnTrayScript;  //Call score script to modify the value

    public GameObject burger;
    public GameObject drink;
    void Start()
    {
        burger.SetActive(false);
        drink.SetActive(false);
    }

    public void toggleFoodLeft ()
    {  
        if (burger.activeSelf)
        {
            burger.SetActive(false);
            foodOnTrayScript.leftFoodTrayItem = 0; //Make tray value back to 0
        }
        else
        {
            burger.SetActive(true);
            drink.SetActive(false);
            foodOnTrayScript.leftFoodTrayItem = 2; //Make tray value back to 0
        }
    }
}
