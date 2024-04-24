using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f; // Prêdkoœæ ko³a
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.angularDrag = 1.0f; // Dodaj opór obrotowy dla lepszego zachowania siê ko³a
    }

    void FixedUpdate()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");

        // Poruszanie ko³em w zale¿noœci od kierunku skrola myszki
        if (scroll > 0f)
        {
            // Skrol w przód, ko³o jedzie w prawo
            rb.AddTorque(-speed);
        }
        else if (scroll < 0f)
        {
            // Skrol w ty³, ko³o jedzie w lewo
            rb.AddTorque(speed);
        }
    }
}

