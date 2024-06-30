using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chodzenie : MonoBehaviour
{
    public float moveSpeed = 5f; // Szybkoœæ poruszania siê gracza
    private Rigidbody2D rb;

    private Quaternion initialRotation; // Pocz¹tkowa rotacja gracza

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initialRotation = transform.rotation; // Zapamiêtaj pocz¹tkow¹ rotacjê gracza
    }

    void Update()
    {
        // Ruch do przodu (w prawo)
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }

        // Ruch do ty³u (w lewo)
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
    }
}
