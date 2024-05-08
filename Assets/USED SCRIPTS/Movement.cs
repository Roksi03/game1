using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5.0f; // Pr�dko�� ko�a
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.angularDrag = 1.0f; // Dodaj op�r obrotowy dla lepszego zachowania si� ko�a
    }

    void FixedUpdate()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");

        // Poruszanie ko�em w zale�no�ci od kierunku skrola myszki
        if (scroll > 0f)
        {
            // Skrol w prz�d, ko�o jedzie w prawo
            rb.AddTorque(-speed);
        }
        else if (scroll < 0f)
        {
            // Skrol w ty�, ko�o jedzie w lewo
            rb.AddTorque(speed);
        }
    }
}

