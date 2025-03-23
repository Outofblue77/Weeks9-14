using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class HoverOverTest : MonoBehaviour
{
    public Image image;

    public Sprite highlight;
    public Sprite normal;

    public TextMeshProUGUI message;

    public void HoverOverTrue ()
    {
        image.sprite = highlight;
        message.text = "Ew";

    }

    public void HoverOverFalse()
    {
        message.text = "Yum";
        image.sprite = normal;
    }

}
