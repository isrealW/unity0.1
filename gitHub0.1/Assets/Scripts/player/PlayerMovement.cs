using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;





    void Update()
    {
        ProcessInput();
        
    }


    void FixedUpdate()
    {
        Move();
    }





    void ProcessInput() // update moveDirection
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized;



    }

    
    void Move()
    {
        rb.velocity = moveDirection * (moveSpeed * Time.fixedDeltaTime * 100);
    }
}
