using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodOnTray : MonoBehaviour
{
    public int leftFoodTrayItem;        //Public to see if it works on unity engine
    public int rightFoodTrayItem;       //Public to see if it works on unity engine
    // Start is called before the first frame update
    void Start()
    {
        leftFoodTrayItem = 0;  
        rightFoodTrayItem = 0;
        //Base score is set to 0 which means tray is empty
    }

}
