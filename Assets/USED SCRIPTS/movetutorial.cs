using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetutorial : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Quaternion initialRotation;
    void Start()
    {
        // Pobierz komponent Rigidbody2D i ustaw gravityScale na 0
        rb = GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.gravityScale = 0;
        }
        initialRotation = transform.rotation;
    }

    void Update()
    {
        // Ruch do przodu (w prawo)
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }

        // Ruch do tyłu (w lewo)
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("wall1"))
        {
            transform.Rotate(Vector3.forward * 90f);
        }

        else if (other.CompareTag("Ground"))
        {
            transform.rotation = initialRotation; // Przywr��
        }

    }
}
