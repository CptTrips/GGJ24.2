using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltMeter : MonoBehaviour
{

    private float angle = 0;

    private float inertia = 1000;

    private float angularVelocity = 0;

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

        angle += angularVelocity * Time.deltaTime;

        Quaternion newRotation = Quaternion.Euler(0, 0, angle);

        transform.rotation = newRotation;
    }

    private float getMoment()
    {

        float moment = 0;

        foreach (PlayerControls character in characters)
        {

            moment += (character.transform.position.x - shipPos.x) * character.RB.mass;
        }

        return moment;
    }
}
