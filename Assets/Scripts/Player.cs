using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public float moveSpeed;

    public float jumpSpeed = 10;

    public float jumpHeight = 3;

    public LayerMask layerMask;

    private Rigidbody2D rb;

    public SpriteRenderer sprite;

    public bool isOnGround = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        var hit = Physics2D.Raycast(transform.position, Vector2.down, 0.51f, layerMask );

        isOnGround = hit.collider != null;

        

        if (Input.GetKey(KeyCode.Space) & isOnGround)
        {
            var speed = Mathf.Sqrt(jumpHeight * -rb.gravityScale * Physics2D.gravity.y * 2);
            rb.velocity = Vector2.up * speed;

            isOnGround = false;

        }

        rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rb.velocity.y);

        playerSide();
        
    }

    void playerSide()
    {
        if (Input.GetKey(KeyCode.A))
        {
            sprite.flipX = true;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            sprite.flipX = false;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isOnGround = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Portal"))
        {
            SceneManager.LoadScene(1);

        }
    }

}
