using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodAppearing : MonoBehaviour
{
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
        }
        else
        {
            burger.SetActive(true);
            drink.SetActive(false);
        }
    }
}
