using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltMeter : MonoBehaviour
{

    private float stability = Mathf.Asin(Mathf.Deg2Rad * 30);

    private float angle = 1F;

    private float seaAngle = 0;

    private float inertia = 1000;

    private float shipMoment = 750F;

    private float angularVelocity = 0;

    private float maxAngularVelocity = 30;

    public List<PlayerControls> characters;

    public GameObject ship;
    private Vector2 shipPos;

    // Start is called before the first frame update
    void Start()
    {

        shipPos = ship.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        angularVelocity += getMoment() / inertia;

        angularVelocity = Mathf.Min(angularVelocity, maxAngularVelocity);

        angle += angularVelocity * Time.deltaTime;

        Quaternion newRotation = Quaternion.Euler(0, 0, angle);

        transform.rotation = newRotation;
    }

    private float getMoment()
    {

        float balance = Mathf.Sin(Mathf.Deg2Rad * angle) / stability;

        float moment = shipMoment * (Mathf.Pow(balance, 3) - balance);

        foreach (PlayerControls character in characters)
        {

            moment += (character.transform.position.x - shipPos.x) * character.RB.mass;
        }

        Debug.Log(moment);

        return moment;
    }
}
