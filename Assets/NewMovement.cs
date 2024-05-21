using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Szybko�� poruszania si� gracza
    private Rigidbody2D rb;
    private bool canMoveSideways = true; // Czy gracz mo�e si� porusza� w bok?
    private bool isRotating = false; // Flaga informuj�ca, czy gracz w�a�nie si� obraca
    private float rotationCooldown = 0.5f; // Czas trwania cooldownu po obrocie
    private float lastRotationTime = -1f; // Czas ostatniego obrotu

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Time.time - lastRotationTime < rotationCooldown)
        {
            return; // Je�li nadal jeste�my w czasie cooldownu, wyjd� z Update
        }

        if (canMoveSideways)
        {
            // Ruch w prawo
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            }
            // Ruch w lewo
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
            }
        }

        // Ruch do przodu
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
        // Ruch do ty�u
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (Time.time - lastRotationTime < rotationCooldown)
        {
            return; // Je�li nadal jeste�my w czasie cooldownu, wyjd� z metody
        }

        if (other.CompareTag("wall1"))
        {
            RotatePlayer(-90f, false);
        }
        else if (other.CompareTag("wall2"))
        {
            RotatePlayer(-90f, true);
        }
        else if (other.CompareTag("wall3"))
        {
            RotatePlayer(-90f, false);
        }
        else if (other.CompareTag("ground"))
        {
            RotatePlayer(-90f, true);
        }
    }

    private void RotatePlayer(float angle, bool enableSideways)
    {
        transform.Rotate(Vector3.forward * angle);
        canMoveSideways = enableSideways;
        lastRotationTime = Time.time; // Ustaw czas ostatniego obrotu
    }
}




