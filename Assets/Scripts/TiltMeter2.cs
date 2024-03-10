using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltMeter2 : MonoBehaviour
{

    public float angle = 1F;

    public float speed = 1;

    [SerializeField]
    private float targetAngle;

    [SerializeField]
    private float sensitivity = 1;

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

            targetAngle = getTargetAngle();

            angularVelocity = speed * (targetAngle - angle);

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

    private float getTargetAngle()
    {

        float moment = 0;

        foreach (PlayerControls character in characters)
        {

            moment += (character.transform.position.x - shipPos.x) * character.RB.mass;
        }

        return sensitivity * moment;
    }
}
