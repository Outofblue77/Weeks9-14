using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class FlySwattedCounter : MonoBehaviour
{
    public Button fly;

    public TextMeshProUGUI customerCount;

    public int numberOfFlies;

    // Start is called before the first frame update
    public void Start()
    {
        numberOfFlies = 0; //Inital score to 0 of flies swatted
        if (fly != null)
        {
            fly.onClick.AddListener(countingKills); //Call/Activate listener
        }
    }
    // Update is called once per frame
    void Update()
    {
        customerCount.text = "Total Flies Swatted: " + numberOfFlies.ToString();
        //Text to display number of flies swatted using variable
    }
    public void countingKills()
    {

        numberOfFlies += 1; //Update number

    }
}
