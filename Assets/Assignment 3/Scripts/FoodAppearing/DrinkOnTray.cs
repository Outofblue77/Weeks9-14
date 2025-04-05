using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkOnTray : MonoBehaviour
{
    public GameObject burger;
    public GameObject drink;
    void Start()
    {
        burger.SetActive(false);
        drink.SetActive(false);
    }

    public void toggleFoodLeft()
    {
        if (drink.activeSelf)
        {
            drink.SetActive(false);
        }
        else
        {
            drink.SetActive(true);
            burger.SetActive(false);
        }
    }
}