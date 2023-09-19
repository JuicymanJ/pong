using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 3.0f;
    public Vector3 direction;
    public SpriteRenderer sprite;

    private void Start()
    {
        SetRandomDirection();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            direction.x = -direction.x;
            direction = direction * 1.25f;
            rb.velocity = direction;
        }
        if (collision.gameObject.tag == "Border")
        {
            direction.y = -direction.y;
            rb.velocity = direction;
        }
        sprite.color = new Color(Random.Range(0,1f), Random.Range(0,1f), Random.Range(0,1f), 1);
    }
    public void Reset()
    {
        transform.position = Vector3.zero;
        SetRandomDirection();
    }
    private void SetRandomDirection()
    {
        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-0.2f, 0.2f));
        direction.Normalize();
        direction *= speed;
        rb.velocity = direction;
    }

}
