using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckingAnswer : MonoBehaviour
{
    public OrderGenerator orderGenerator;
    public FoodOnTray foodOnTray;
    //Grab both score (Customer order and food on tray) scripts

    public void checkScore ()
    {
        if (foodOnTray.leftFoodTrayItem == orderGenerator.leftFood && foodOnTray.rightFoodTrayItem == orderGenerator.rightFood) //See if both tray items match the customer order
        {
            //(Add code to give play points)
        }
        else
        {
            //(Add code to remove play points
        }
    }
}
