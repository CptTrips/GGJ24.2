using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    Vector2 Movement;
    public Rigidbody2D RB;
    public float MoveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Rubbish comment
    void Update()
    {
        Movement.x = Input.GetAxis("Horizontal");
        Movement.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        RB.MovePosition(RB.position + Movement * MoveSpeed * Time.fixedDeltaTime);
    }
}