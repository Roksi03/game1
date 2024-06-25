using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Szybkość poruszania się gracza
    private Rigidbody2D rb;
    private bool canMoveSideways = true; // Czy gracz może się poruszać w bok?
    private bool canMoveUpDown = true; // Czy gracz może się poruszać do góry i na dół?

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0; // Wyłącz grawitację
    }

    void Update()
    {
        Vector2 moveDirection = Vector2.zero;

        if (canMoveSideways)
        {
            if (Input.GetKey(KeyCode.D))
            {
                moveDirection += Vector2.right;
            }
            if (Input.GetKey(KeyCode.A))
            {
                moveDirection += Vector2.left;
            }
        }

        if (canMoveUpDown)
        {
            if (Input.GetKey(KeyCode.W))
            {
                moveDirection += Vector2.up;
            }
            if (Input.GetKey(KeyCode.S))
            {
                moveDirection += Vector2.down;
            }
        }

        rb.velocity = moveDirection.normalized * moveSpeed;
    }

    void FixedUpdate()
    {
        // Zablokuj ruch w osi Y, aby zapobiec opadaniu
        if (!canMoveUpDown)
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("wall1"))
        {
            transform.Rotate(Vector3.forward * -90f);
            rb.velocity = Vector2.zero;
            rb.simulated = true; // Zatrzymaj ruch przed obrotem
            canMoveSideways = false; // Wyłącz możliwość ruchu w bok
            canMoveUpDown = true; // Włącz możliwość ruchu w pionie
        }
        else if (other.CompareTag("ceiling"))
        {
            transform.Rotate(Vector3.forward * -90f);
            rb.velocity = Vector2.zero;
            rb.simulated = true; // Zatrzymaj ruch przed obrotem
            canMoveSideways = true; // Włącz możliwość ruchu w bok
            canMoveUpDown = false; // Wyłącz możliwość ruchu w pionie
            Debug.Log("dwdw");
        }
        else if (other.CompareTag("wall3"))
        {
            transform.Rotate(Vector3.forward * -90f);
            rb.velocity = Vector2.zero;
            rb.simulated = true; // Zatrzymaj ruch przed obrotem
            canMoveSideways = false; // Wyłącz możliwość ruchu w bok
            canMoveUpDown = true; // Włącz możliwość ruchu w pionie
        }

        else if (other.CompareTag("wall4"))
        {
            transform.Rotate(Vector3.forward * 90f);
            rb.velocity = Vector2.zero;
            rb.simulated = true; // Zatrzymaj ruch przed obrotem
            canMoveSideways = false; // Wyłącz możliwość ruchu w bok
            canMoveUpDown = true; // Włącz możliwość ruchu w pionie
        }
    }
}
