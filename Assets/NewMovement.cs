using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Szybkoœæ poruszania siê gracza
    private Rigidbody2D rb;
    private bool canMoveSideways = true; // Czy gracz mo¿e siê poruszaæ w bok?

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
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
        // Ruch do ty³u
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        // Jeœli gracz dotyka obiektu o tagu "wall1"
        if (other.CompareTag("wall1"))
        {
            // Obróæ gracza o 90 stopni w lewo
            transform.Rotate(Vector3.forward * -90f);
            rb.simulated = false;
            canMoveSideways = false; // Wy³¹cz mo¿liwoœæ ruchu w bok
        }
        if (other.CompareTag("wall2"))
        {
            
            transform.Rotate(Vector3.forward * -180f);
            rb.simulated = false;
            canMoveSideways = true; // 
            Debug.Log("dwdw");
        }
        if (other.CompareTag("wall3"))
        {
            // Obróæ gracza o 90 stopni w lewo
            transform.Rotate(Vector3.forward * 90f);
            rb.simulated = false;
            canMoveSideways = false; // Wy³¹cz mo¿liwoœæ ruchu w bok
        }
    }
}

    




