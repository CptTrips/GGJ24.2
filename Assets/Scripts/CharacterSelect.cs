using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelect : MonoBehaviour
{
    public int CharacterNo;
    public GameObject P1Box;
    public GameObject P2Box;
    public GameObject P3Box;
    public GameObject P4Box;
    public GameObject P5Box;
    public GameObject P6Box;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player4;
    public GameObject Player5;
    public GameObject Player6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (CharacterNo < 5)
            {
                CharacterNo += 1;
            }            
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (CharacterNo > 0)
            {
                CharacterNo -= 1;
            }            
        }

        if (CharacterNo == 0)
        {
            P1Box.SetActive(true);
            P2Box.SetActive(false);
            P3Box.SetActive(false);
            P4Box.SetActive(false);
            P5Box.SetActive(false);
            P6Box.SetActive(false);
            Player1.GetComponent<PlayerControls>().enabled = true;
            Player2.GetComponent<PlayerControls>().enabled = false;
            Player3.GetComponent<PlayerControls>().enabled = false;
            Player4.GetComponent<PlayerControls>().enabled = false;
            Player5.GetComponent<PlayerControls>().enabled = false;
            Player6.GetComponent<PlayerControls>().enabled = false;
        }

        if (CharacterNo == 1)
        {
            P1Box.SetActive(false);
            P2Box.SetActive(true);
            P3Box.SetActive(false);
            P4Box.SetActive(false);
            P5Box.SetActive(false);
            P6Box.SetActive(false);
            Player1.GetComponent<PlayerControls>().enabled = false;
            Player2.GetComponent<PlayerControls>().enabled = true;
            Player3.GetComponent<PlayerControls>().enabled = false;
            Player4.GetComponent<PlayerControls>().enabled = false;
            Player5.GetComponent<PlayerControls>().enabled = false;
            Player6.GetComponent<PlayerControls>().enabled = false;
        }

        if (CharacterNo == 2)
        {
            P1Box.SetActive(false);
            P2Box.SetActive(false);
            P3Box.SetActive(true);
            P4Box.SetActive(false);
            P5Box.SetActive(false);
            P6Box.SetActive(false);
            Player1.GetComponent<PlayerControls>().enabled = false;
            Player2.GetComponent<PlayerControls>().enabled = false;
            Player3.GetComponent<PlayerControls>().enabled = true;
            Player4.GetComponent<PlayerControls>().enabled = false;
            Player5.GetComponent<PlayerControls>().enabled = false;
            Player6.GetComponent<PlayerControls>().enabled = false;
        }

        if (CharacterNo == 3)
        {
            P1Box.SetActive(false);
            P2Box.SetActive(false);
            P3Box.SetActive(false);
            P4Box.SetActive(true);
            P5Box.SetActive(false);
            P6Box.SetActive(false);
            Player1.GetComponent<PlayerControls>().enabled = false;
            Player2.GetComponent<PlayerControls>().enabled = false;
            Player3.GetComponent<PlayerControls>().enabled = false;
            Player4.GetComponent<PlayerControls>().enabled = true;
            Player5.GetComponent<PlayerControls>().enabled = false;
            Player6.GetComponent<PlayerControls>().enabled = false;
        }

        if (CharacterNo == 4)
        {
            P1Box.SetActive(false);
            P2Box.SetActive(false);
            P3Box.SetActive(false);
            P4Box.SetActive(false);
            P5Box.SetActive(true);
            P6Box.SetActive(false);
            Player1.GetComponent<PlayerControls>().enabled = false;
            Player2.GetComponent<PlayerControls>().enabled = false;
            Player3.GetComponent<PlayerControls>().enabled = false;
            Player4.GetComponent<PlayerControls>().enabled = false;
            Player5.GetComponent<PlayerControls>().enabled = true;
            Player6.GetComponent<PlayerControls>().enabled = false;
        }

        if (CharacterNo == 5)
        {
            P1Box.SetActive(false);
            P2Box.SetActive(false);
            P3Box.SetActive(false);
            P4Box.SetActive(false);
            P5Box.SetActive(false);
            P6Box.SetActive(true);
            Player1.GetComponent<PlayerControls>().enabled = false;
            Player2.GetComponent<PlayerControls>().enabled = false;
            Player3.GetComponent<PlayerControls>().enabled = false;
            Player4.GetComponent<PlayerControls>().enabled = false;
            Player5.GetComponent<PlayerControls>().enabled = false;
            Player6.GetComponent<PlayerControls>().enabled = true;
        }
    }
}
