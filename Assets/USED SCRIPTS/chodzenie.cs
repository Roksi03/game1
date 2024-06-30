using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chodzenie : MonoBehaviour
{
    public float moveSpeed = 5f; // Szybko�� poruszania si� gracza
    private Rigidbody2D rb;

    private Quaternion initialRotation; // Pocz�tkowa rotacja gracza

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initialRotation = transform.rotation; // Zapami�taj pocz�tkow� rotacj� gracza
    }

    void Update()
    {
        // Ruch do przodu (w prawo)
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }

        // Ruch do ty�u (w lewo)
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
    }
}
