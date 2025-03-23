using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerHex : MonoBehaviour
{
    public GameObject prefab;
    public Button buttontoChangeColor;

    public void Spawn ()
    {
        GameObject newHexagon = Instantiate (prefab, Random.insideUnitCircle*4, transform.rotation);
        ColorChangeButton hexagon = newHexagon.GetComponent<ColorChangeButton> ();

        buttontoChangeColor.onClick.AddListener(hexagon.ChangeColor);
    }
    
}
