using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TaskSystem : MonoBehaviour
{

    private Task[] tasks;

    // Start is called before the first frame update
    void Start()
    {

        tasks = GetComponents<Task>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
