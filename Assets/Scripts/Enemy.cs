
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    public float direction = 1;

    public Rigidbody2D rb;
    void Update()
    {

        rb.velocity = new Vector2(speed * direction, rb.velocity.y);
    }



    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.CompareTag("InvCol"))
        {
            direction = -direction;

        }
    }
}
