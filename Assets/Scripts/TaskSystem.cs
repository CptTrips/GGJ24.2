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

    private int currentTask = 0;

    public bool tasksComplete = false;

    private Text prompt;

    // Start is called before the first frame update
    void Start()
    {

        tasks = GetComponents<Task>().ToList<Task>();
    }

    // Update is called once per frame
    void Update()
    {

        if (taskComplete())
            nextTask();
    }

    bool taskComplete()
    {

        foreach (GameObject player  in players)
        {
            if (false)
                return true;
        }

        return false;
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
        }
    }
}

