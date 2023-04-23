
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public SpriteRenderer sprite;

    public float speed;



    public Rigidbody2D rb;
    void Update()
    {

        rb.velocity = new Vector2(speed, rb.velocity.y);
    }



    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("InvCol"))
        {
            speed = -speed;
            sprite.flipX = !sprite.flipX;
        }
    }
}
