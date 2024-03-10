using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSystem : MonoBehaviour
{
    public GameObject IntroPanel;

    // Start is called before the first frame update
    void Start()
    {

        Time.timeScale = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Level1()
    {

        Time.timeScale = 1.0f;
        IntroPanel.SetActive(false);
    }
}
