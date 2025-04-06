using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CustomerMovement : MonoBehaviour
{
    //public Image uiCharacterA; 
    //public Image uiCharacterB;

    public float speed = 0;   //Creating a placeholder to control the speed
    public float distance;    //Track placement and movent through unity ui

    private RectTransform rectTransform; //Stores transform of the ui component

    public void clicked()   //New void to call on when the character is clicked on
    {
        rectTransform = GetComponent<RectTransform>(); //get the UI Image 
        StartCoroutine(moveLeft());  //Call to start the coroutine
    }
    
    public IEnumerator moveLeft()  //Call to use coroutine
    {
        distance = 0f; //Set loop to start at 0
        while (distance < 550) //Loop to move character. 550 indicating distance
        {
            float step = speed * Time.deltaTime;  //Add delta time to make movemnt consistent
            rectTransform.anchoredPosition -= new Vector2(step, 0f);  //Update the UI placement 
            distance += step;  //Add the distance moved to the ui image
            yield return null; //Stop until next fram to continue while loop
        }

    }
}
