using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float levelDuration = 60;

    [SerializeField]
    private float timeRemaining;

    [SerializeField]
    private SceneController sceneController;

    bool timeout = false;

    [SerializeField]
    private Text textBox;

    // Start is called before the first frame update
    void Start()
    {

        timeRemaining = levelDuration;
    }

    // Update is called once per frame
    void Update()
    {

        if (!timeout)
            timeRemaining -= Time.deltaTime;

        if (timeRemaining < 0)
            gameOver();

        updateText();
    }

    private void updateText()
    {

        textBox.text = string.Format("Time Remaining: {0:n}", timeRemaining);
    }

    private void gameOver()
    {

        timeRemaining = 0;

        timeout = true;

        sceneController.gameOver();
    }
}
