using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public TextMeshProUGUI scoreValue;  //Grab Text mesh on unity

    public int value; //Variable to hold score

    // Start is called before the first frame update
    void Start()
    {
        value = 0; //Set initial score to 0
    }

    // Update is called once per frame
    void Update()  //In update ot constanly be updationg player score
    {
        scoreValue.text = "Score: " + value.ToString();  //Show text with score in it.
    }
}
