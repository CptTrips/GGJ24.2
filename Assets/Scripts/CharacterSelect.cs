using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    public int CharacterNo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            CharacterNo += 1;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            CharacterNo -= 1;
        }
    }
}
