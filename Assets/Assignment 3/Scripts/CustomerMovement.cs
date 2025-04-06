using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CustomerMovement : MonoBehaviour
{
    //public Image uiCharacterA; 
    //public Image uiCharacterB;
    public GameObject bubble; //Call displaybubblle to turn on

    public float speed = 0;   //Creating a placeholder to control the speed
    public float distance = 0f;    //Track placement and movent through unity ui

    public Vector2 startPosition; //Vector to track and set a customer position before they enter the screen
    private RectTransform character; //Stores transform of the ui component

    public void Start()
    {
        startPosition = new Vector2(545, 61); //Set cords to telport customer back to rigth side
    }

    public void clicked()   //New void to call on when the character is clicked on
    {
        character = GetComponent<RectTransform>(); //get the UI Image 
        StartCoroutine(moveLeft());  //Call to start the coroutine
    }

    public IEnumerator moveLeft()  //Call to use coroutine
    {
        distance = 0f; //Set loop to start at 0

        while (distance < 545) //Loop to move character. 550 indicating distance
        {
            float step = speed * Time.deltaTime;  //Add delta time to make movemnt consistent
            character.anchoredPosition -= new Vector2(step, 0f);  //Update the UI placement 
            distance += step;  //Add the distance moved to the ui image
            yield return null; //Stop until next fram to continue while loop
        }

        yield return new WaitForSeconds(0.5f); //Cool, makes a delay befor  executing following codes (Makes smoother transition)

        bubble.SetActive(true); //Activate bubble display for new customer
        if (character.anchoredPosition.x < -530) //Check if character is off screen
        {
            character.anchoredPosition = startPosition; //Teleport customer back to starting position (off screen left sode)
        }
    }
}
