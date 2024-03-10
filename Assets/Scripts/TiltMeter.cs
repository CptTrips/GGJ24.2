using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltMeter : MonoBehaviour
{

    public float stability = Mathf.Asin(Mathf.Deg2Rad * 30);

    public float angle = 1F;

    public float seaAngle = 0;

    public float inertia = 1000;

    public float shipMoment = 750F;

    public float angularVelocity = 0;

    public float maxAngularVelocity = 30;

    public float gameOverAngle = 45;

    public List<PlayerControls> characters;

    public GameObject ship;
    private Vector2 shipPos;

    public SceneController sceneController;

    private bool enablePhysics = true;

    // Start is called before the first frame update
    void Start()
    {

        shipPos = ship.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (enablePhysics)
        {
            angularVelocity += getMoment() / inertia;

            angularVelocity = Mathf.Min(angularVelocity, maxAngularVelocity);

            angle += angularVelocity * Time.deltaTime;

            if (Mathf.Abs(angle) > gameOverAngle)
                gameOver();

            Quaternion newRotation = Quaternion.Euler(0, 0, angle);

            transform.rotation = newRotation;
        }
    }

    private void gameOver()
    {

        Debug.Log("Game over");
        enablePhysics = false;

        sceneController.gameOver();
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
