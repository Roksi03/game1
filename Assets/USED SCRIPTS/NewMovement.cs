using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Szybkość poruszania się gracza
    private Rigidbody2D rb;
    public Collider2D triggerToDisableAtStart;
    public Collider2D triggerToEnableAtStart;
    public Collider2D triggerToEnableAtStart2;
    public Collider2D triggerToDisableAtStart2;
    public Collider2D triggerToEnableAtStart3;
    public Collider2D triggerToDisableAtStart3;
    

    private Quaternion initialRotation; // Początkowa rotacja gracza

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initialRotation = transform.rotation; // Zapamiętaj początkową rotację gracza
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
        // Jeśli gracz minie trigger 2, wyłącz go i obróć postać
        if (other == triggerToEnableAtStart)
        {
            triggerToEnableAtStart.enabled = true;
            transform.Rotate(Vector3.forward * 90f);
        }
        // Jeśli gracz minie trigger 1, włącz go i obróć postać
        else if (other == triggerToDisableAtStart)
        {
            triggerToDisableAtStart.enabled = true;
            transform.Rotate(Vector3.forward *90f);
        }
        if (other == triggerToEnableAtStart2)
        {
            triggerToEnableAtStart2.enabled = true;
            transform.Rotate(Vector3.forward * 90f);// Wyłącz triggerToEnableAtStart2 dopiero gdy go minie
                                                    // Dodaj odpowiednie działania, np. obrót postaci
        }
        else if (other == triggerToDisableAtStart2)
        {
            triggerToDisableAtStart2.enabled = true;
            transform.Rotate(Vector3.forward * 90f);// Włącz triggerToDisableAtStart2 dopiero gdy go minie
                                                    // Dodaj odpowiednie działania, np. obrót postaci
        }

        if (other == triggerToEnableAtStart3)
        {
            triggerToEnableAtStart2.enabled = true;
            transform.Rotate(Vector3.forward * 90f);// Wyłącz triggerToEnableAtStart2 dopiero gdy go minie
                                                    // Dodaj odpowiednie działania, np. obrót postaci
        }
        else if (other == triggerToDisableAtStart3)
        {
            triggerToDisableAtStart2.enabled = true;
            transform.Rotate(Vector3.forward * 90f);// Włącz triggerToDisableAtStart2 dopiero gdy go minie
                                                    // Dodaj odpowiednie działania, np. obrót postaci
        }

        if (other.CompareTag("wall4"))
        {
            transform.Rotate(Vector3.forward * -90f);

        }
        if (other.CompareTag("wall5"))
        {
            transform.Rotate(Vector3.forward * -90f);

        }
        if (other.CompareTag("wall6"))
        {
            transform.Rotate(Vector3.forward * -90f);

        }



    }


    void OnTriggerExit2D(Collider2D other)
    {
        // Jeśli gracz opuszcza kolider "wall1", "wall1-", "wall4" lub "wall5", przywróć początkową rotację gracza
        if (other.CompareTag("wall1") || other.CompareTag("wall1-")) 
        {
            transform.rotation = initialRotation; // Przywróć początkową rotację gracza
            rb.velocity = Vector2.zero; // Zatrzymaj prędkość gracza
        }

    }
}







