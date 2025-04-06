using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OrderGenerator : MonoBehaviour
{   
    //Variables to store the data of what food is being requested
    public float leftFoodRequest;   //0 = nothing || 1 = Drink || 2 = Burger
    public float rightFoodRequest;  //0 = nothing || 1 = Fries || 2 = Hotdog || 3 = Popcorn

    public GameObject orderDrink;
    public GameObject orderBurger;

    public GameObject orderFries;
    public GameObject orderHotdog;
    public GameObject orderPopcorn;

    public void Start()
    {
        foodOrder();
    }
    public void foodOrder()
    {
        float leftFood = Random.Range(0, 2);
        float rightFood = Random.Range(0, 3);

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
}
