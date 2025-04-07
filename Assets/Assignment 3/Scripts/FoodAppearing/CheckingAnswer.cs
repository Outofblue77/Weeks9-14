using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckingAnswer : MonoBehaviour
{   
    public OrderGenerator orderGenerator;
    public FoodOnTray foodOnTray;
    //Grab both score (Customer order and food on tray) scripts
    public PlayerScore playerScore;
    //Grab player score script to adjust the score
    public CustomerMovement customerWalking;
    public void checkScore()
    {
        if (customerWalking.IsWalking == false)
        {
            if (foodOnTray.leftFoodTrayItem == orderGenerator.leftFood && foodOnTray.rightFoodTrayItem == orderGenerator.rightFood) //See if both tray items match the customer order
            {
                playerScore.value += 100;
                //(Add code to give play points)
            }
            else
            {
                playerScore.value -= 100;
                //(Add code to remove play points
            }
        }
    }
}
