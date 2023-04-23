using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    private Rigidbody2D rb;

    public float speed = 3;

    public SpriteRenderer sprite;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //transform.position += Vector3.right;

        rb.velocity = new Vector2(speed, rb.velocity.y);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (!collision.gameObject.CompareTag("EnemyWall")) return;
        speed = -speed;

        sprite.flipX = !sprite.flipX;
    }
}
