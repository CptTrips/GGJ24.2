using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltMeter : MonoBehaviour
{

    float angle;

    const float period = 2;

    const float amplitude = 45; // degrees

    // Start is called before the first frame update
    void Start()
    {

        angle = 0;
    }

    // Update is called once per frame
    void Update()
    {


        angle = amplitude * Mathf.Sin(2 * Mathf.PI * Time.realtimeSinceStartup / period);

        Quaternion newRotation = Quaternion.Euler(0, 0, angle);

        transform.rotation = newRotation;
    }
}
