using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Szybkość poruszania się gracza
    private Rigidbody2D rb;
    
    private bool canMoveBackwards = true;
   

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }

        // Ruch do tyłu
        if (canMoveBackwards && Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
    }

    
    public void OnTriggerEnter2D(Collider2D other)
    {
        // Jeśli gracz dotyka ściany
        if (other.CompareTag("wall1"))
        {
            // Obróć gracza o 90 stopni w lewo
            transform.Rotate(Vector3.forward * 90f);
            rb.velocity = Vector2.zero;
            
            canMoveBackwards = false;
            rb.isKinematic = true;
        }
        // Jeśli gracz dotknie innej ściany
        else if (other.CompareTag("wall2"))
        {
            // Obróć gracza o 90 stopni w prawo
            transform.Rotate(Vector3.forward * 90f);
            rb.simulated = false;
             // Włącz możliwość ruchu w bok
        }
        // Jeśli gracz dotknie sufitu
        else if (other.CompareTag("Ceiling"))
        {
            // Obróć gracza o 180 stopni wokół osi Z (do góry nogami)
            transform.Rotate(Vector3.forward * 180f);
            rb.simulated = false;
             // Włącz możliwość ruchu w bok
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Exit trigger: " + other.tag);

        // Jeśli gracz opuszcza kolider
        if (other.CompareTag("wall1") || other.CompareTag("wall2"))
        {
            // Przywróć początkową rotację gracza
            transform.rotation = Quaternion.identity; // Przywróć początkową rotację (brak obrotu)
            rb.simulated = true;
            
            canMoveBackwards = true;
            rb.isKinematic = false;
            // Włącz możliwość ruchu w bok
        }
    }
}


