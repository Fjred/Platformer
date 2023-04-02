using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public float jumpSpeed;

    void Start()
    {
        
    }


    private void Update()
    {
        
        Walk();
        

        Jump();
    }

    void Walk()
    {
        

        if (Input.GetKey(KeyCode.D))
            rb.velocity = new Vector2(speed, 0);
        if (Input.GetKey(KeyCode.A))
            rb.velocity = new Vector2(-speed, 0);
    }
    void Jump()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(0, jumpSpeed);
        }
    }
}
