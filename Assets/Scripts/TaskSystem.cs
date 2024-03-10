using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;


public class TaskSystem : MonoBehaviour
{

    private List<Task> tasks;

    private List<GameObject> players;

    [SerializeField]
    private int currentTask = 0;

    public bool tasksComplete = false;

    [SerializeField]
    private Text prompt;

    [SerializeField]
    private SceneController sceneController;

    // Start is called before the first frame update
    void Start()
    {

        tasks = GetComponents<Task>().ToList<Task>();
    }

    // Update is called once per frame
    void Update()
    {

        if (!tasksComplete && taskComplete())
            nextTask();
    }

    bool taskComplete()
    {

        TaskArea collider = tasks[currentTask].objective.GetComponentInChildren<TaskArea>();

        return collider.occupied;
    }

    void nextTask()
    {

        if (currentTask + 1 < tasks.Count)
        {
            currentTask++;
            prompt.text = tasks[currentTask].prompt;
        }
        else
        {
            tasksComplete = true;
            prompt.text = "";

            sceneController.gameOver();
        }
    }
}

