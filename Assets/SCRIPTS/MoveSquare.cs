using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSquare : MonoBehaviour
{
    public float speed = 5f; 
    public Vector2 direction = Vector2.right;
    private Rigidbody2D rb;
    void Start()
    {
          rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Move o objeto na direção especificada
        rb.velocity = direction * speed;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Para o movimento do cubo quando colidir com outro objeto
        if (collision.gameObject.GetComponent<Collider2D>() != null)
        {
            rb.velocity = Vector2.zero;
        }
    }
}
