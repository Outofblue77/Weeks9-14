using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public TextMeshProUGUI scoreValue;

    public int value;

    // Start is called before the first frame update
    void Start()
    {
        value = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        scoreValue.text = "Score: " + value.ToString();
    }
}
