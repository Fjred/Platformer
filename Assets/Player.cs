using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;

    public float jumpSpeed = 10;

    public float jumpHeight = 3;

    private Rigidbody2D rb;


    public bool isOnGround = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        



        if (Input.GetKey(KeyCode.Space) & isOnGround)
        {
            var speed = Mathf.Sqrt(jumpHeight * -rb.gravityScale * Physics2D.gravity.y * 2);
            rb.velocity = Vector2.up * speed;

            isOnGround = false;
        }

        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rb.velocity.y);

        
    }




    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOnGround = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isOnGround = false;
    }
}
