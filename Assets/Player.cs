using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    void Start()
    {
        
    }


    private void Update()
    {
        Jump();

        rb.velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.D))
            rb.velocity = new Vector3(speed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.A))
            rb.velocity = new Vector3(-speed * Time.deltaTime, 0, 0);

    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //rb.velocity = new Vector2(0, jumpSpeed);
        }
    }
}
