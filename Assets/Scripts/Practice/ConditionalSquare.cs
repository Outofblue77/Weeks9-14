using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalSquare : MonoBehaviour
{
    public float t;

    public void Grow()
    {
        StartCoroutine(GetBigger());
    }

    // Update is called once per frame
    IEnumerator GetBigger()
    {
        if (t < 1)
        {
            t += Time.deltaTime;
            transform.localScale = Vector3.one * t;
            yield return null;
        }
    }
}
