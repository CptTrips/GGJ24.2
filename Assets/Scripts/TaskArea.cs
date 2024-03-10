using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskArea : MonoBehaviour
{

    [SerializeField]
    private int occupation = 0;

    public bool occupied = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        occupation++;

        occupied = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        occupation--;

        if (occupation < 0)
            occupation = 0;

        if (occupation == 0)
            occupied = false;

    }
}
