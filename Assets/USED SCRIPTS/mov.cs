using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
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

    void OnTriggerEnter2D(Collider2D other)
    {
        // Jeœli gracz minie trigger 1 i nie zosta³ jeszcze aktywowany, obróæ postaæ
        if (other.CompareTag("wall1") )
        {
           
            transform.Rotate(Vector3.forward * 90f);
        }
        // Jeœli gracz minie trigger 2 i nie zosta³ jeszcze aktywowany, obróæ postaæ
        else if (other.CompareTag("wall2") )
        {
            
            transform.Rotate(Vector3.forward * 90f);
        }
        // Jeœli gracz minie trigger 3 i nie zosta³ jeszcze aktywowany, obróæ postaæ
        else if (other.CompareTag("wall4") )
        {
           
            transform.Rotate(Vector3.forward * -90f);
        }
        else if (other.CompareTag("wall3"))
        {
            transform.Rotate(Vector3.forward * -90f);
        }
         else if (other.CompareTag("Ground"))
        {
            transform.rotation = initialRotation; // Przywróæ pocz¹tkow¹ rotacjê gracza
            rb.velocity = Vector2.zero;
        }
        else if (other.CompareTag("Cant"))
        {
            Debug.Log("You can't go there");
        }
    }

   

}
