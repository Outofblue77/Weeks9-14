using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeButton : MonoBehaviour
{
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    
    public void ChangeColor ()
    {
        sr.color = Random.ColorHSV();
    }

}
