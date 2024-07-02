using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rolling2 : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Prêdkoœæ poruszania siê paj¹ka
    public float rotateSpeed = 100f; // Prêdkoœæ obrotu paj¹ka

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Mouse ScrollWheel");

        // Poruszanie paj¹ka w zale¿noœci od kierunku scrolla myszy
        Vector2 movement = new Vector2(horizontalInput, 0);
        rb.velocity = movement * moveSpeed;

        // Obracanie paj¹ka tylko wtedy, gdy scroll myszy jest ró¿ny od zera
        if (horizontalInput != 0)
        {
            // Obrót paj¹ka
            float rotation = -horizontalInput * rotateSpeed * Time.deltaTime;
            transform.Rotate(Vector3.forward, rotation);
        }
    }

}
