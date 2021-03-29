using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Movement goes here, once pr frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        movement.x = horizontal;
        movement.y = vertical;
       
    }


    //Fixed is for physics, default is 50 times pr second
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); //rb.position is current position, add new vector and multiple it with speed and time 
    }
}
