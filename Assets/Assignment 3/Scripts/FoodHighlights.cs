using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI; 
//Using unity UI

public class FoodHighlights : MonoBehaviour
{
    public Image image;
    public Sprite normal;
    public Sprite highlight;
    //Creating public to access through unity tab

    public void mouseNotOnFood()
    {
        image.sprite = normal;
        // Call base sprite when mouse is not hovering
    }
    public void mouseOnFood()
    {
        image.sprite = highlight;
        // Call new sprite with highlight when mosu is hovering
    }

}
