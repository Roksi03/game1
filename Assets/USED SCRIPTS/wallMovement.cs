using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallMovement : MonoBehaviour
{
    private float vertical;
    private float speed = 8f;
    private bool isWall;
    private bool isClimbing;


    [SerializeField] private Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");


        if (isWall && Mathf.Abs(vertical) > 0f)
        {
            isClimbing = true;
        }
    }

    private void FixedUpdate()
    {
        if (isClimbing)
        {
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(rb.velocity.x, vertical * speed);
        }
        else
        {
            rb.gravityScale = 1f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("wall"))
        {
            isWall = true;
        }

        if (collision.CompareTag("ceiling"))
        {
            rb.gravityScale = 0;
            isWall = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("wall"))
        {
            isWall = false;
            isClimbing = false;
        }

        if (collision.CompareTag("ceiling"))
        {
            isWall = false;
            isClimbing = false;
        }
    }
}
