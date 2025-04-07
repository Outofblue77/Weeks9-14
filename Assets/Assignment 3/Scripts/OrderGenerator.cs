using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OrderGenerator : MonoBehaviour
{   
    //Variables to store the data of what food is being requested
    

    public GameObject orderDrink;
    public GameObject orderBurger;

    public GameObject orderFries;
    public GameObject orderHotdog;
    public GameObject orderPopcorn;

    //Variables to store the data of what food is being requested
    public int rightFood; //Create variables in class so all voids can use them
    public int leftFood;  //Create variables in class so all voids can use them
    //0 = nothing || 1 = Drink || 2 = Burger
    //0 = nothing || 1 = Fries || 2 = Hotdog || 3 = Popcorn
    public void Start()
    {
        foodOrder();
        //Start food order
    }
    public void foodOrder()  //Void to store what food is requested and to display it
    {
        leftFood = Random.Range(0, 3); //Generate a random number between 0 and 2 to assign a food
        if (leftFood == 0) //Incase the is no food picked on the left side, new random that guarantees a food on the right
        {
            rightFood = Random.Range(1, 4); //Generate 1 to 3 to guarantee a food item appears
        }
        else
        {
            rightFood = Random.Range(0, 4); //Generate a randome number between 0 to 3 for a food 
        }
        /////////////////////////////////
        //Making the correct left food appear according to the variable
        if (leftFood == 0)
        {
            orderBurger.SetActive(false);
            orderDrink.SetActive(false);
        }
        else if (leftFood == 1)
        {
            orderDrink.SetActive(true);
            orderBurger.SetActive(false);
        }
        else if (leftFood == 2)
        {
            orderBurger.SetActive(true);
            orderDrink.SetActive(false);
        }
        /////////////////////////////////
        //Making the correct right food appear according to the variable
        if (rightFood == 0)
        {
            orderFries.SetActive(false);
            orderHotdog.SetActive(false);
            orderPopcorn.SetActive(false);
        }
        else if (rightFood == 1)
        {
            orderFries.SetActive(true);
            orderHotdog.SetActive(false);
            orderPopcorn.SetActive(false);
        }
        else if (rightFood == 2)
        {
            orderHotdog.SetActive(true);
            orderFries.SetActive(false);
            orderPopcorn.SetActive(false);
        }
        else if (rightFood == 3)
        {
            orderPopcorn.SetActive(true);
            orderFries.SetActive(false);
            orderHotdog.SetActive(false);
        }
    }

    public void foodSubmitted () //Void to reset the variables and hide all the objects 
    {
        leftFood = 0;
        rightFood = 0;

        orderBurger.SetActive(false);
        orderDrink.SetActive(false);
        orderFries.SetActive(false);
        orderHotdog.SetActive(false);
        orderPopcorn.SetActive(false);
    }
}
