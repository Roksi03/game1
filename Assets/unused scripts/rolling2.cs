using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rolling2 : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Pr�dko�� poruszania si� paj�ka
    public float rotateSpeed = 100f; // Pr�dko�� obrotu paj�ka

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Mouse ScrollWheel");

        // Poruszanie paj�ka w zale�no�ci od kierunku scrolla myszy
        Vector2 movement = new Vector2(horizontalInput, 0);
        rb.velocity = movement * moveSpeed;

        // Obracanie paj�ka tylko wtedy, gdy scroll myszy jest r�ny od zera
        if (horizontalInput != 0)
        {
            // Obr�t paj�ka
            float rotation = -horizontalInput * rotateSpeed * Time.deltaTime;
            transform.Rotate(Vector3.forward, rotation);
        }
    }

}
