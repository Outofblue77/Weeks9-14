using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckingAnswer : MonoBehaviour
{
    
    public int addedScore;
    public OrderGenerator orderGenerator;
    public FoodOnTray foodOnTray;
    //Grab both score (Customer order and food on tray) scripts
    public PlayerScore playerScore;
    //Grab player score script to adjust the score
    public FlyMovement flyScript;
    //grab fly script to begin its movement
    public CustomerMovement customerWalking;
    //Check if customer is in walking cycle

    public void Start()
    {
        addedScore = 100;
    }
    public void checkScore()
    {
        if (customerWalking.IsWalking == false)
        {
            if (foodOnTray.leftFoodTrayItem == orderGenerator.leftFood && foodOnTray.rightFoodTrayItem == orderGenerator.rightFood) //See if both tray items match the customer order
            {
                playerScore.value += addedScore;
                //(Add code to give play points)
            }
            else
            {
                playerScore.value -= 100;
                flyScript.wrongOrder();

                //(Add code to remove play points
            }
        }
    }
}
