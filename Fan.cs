using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    public float fanspeed = 1000;
    void Update()
    {
        transform.Rotate(fanspeed * Time.deltaTime, 0, 0);
    }
}
