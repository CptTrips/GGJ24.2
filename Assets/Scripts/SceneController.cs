using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public GameObject gameOverPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoadLevel1()
    {

        SceneManager.LoadScene("Level1");
    }

    public void gameOver()
    {

        // Load GameOver prefab
        Instantiate(gameOverPrefab);

        Time.timeScale = 0.0f;
    }
}
