using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CustomerMovement : MonoBehaviour
{
    public float speed = 1;
    public void walkingAway ()
    {
        Vector3 pos = transform.position;
        pos.x = speed * Time.deltaTime;

        transform.position = pos;
    }
}
