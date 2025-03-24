using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopSquare : MonoBehaviour
{
    public float t;

    public void Growt()
    {
        StartCoroutine(GetBigger());
    }

    // Update is called once per frame
    IEnumerator GetBigger()
    {   
        t=0;
        while (t < 1)
        {
            t += Time.deltaTime;
            transform.localScale = Vector3.one * t;
            yield return null;
        }


    }
}
