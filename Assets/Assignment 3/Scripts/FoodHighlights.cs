using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class FoodHighlights : MonoBehaviour
{
    public Image image;
    public Sprite normal;
    public Sprite highlight;

    public void mouseNotOnFood()
    {
        image.sprite = normal;
    }
    public void mouseOnFood()
    {
        image.sprite = highlight;
    }

}
