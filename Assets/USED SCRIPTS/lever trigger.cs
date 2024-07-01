using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levertrigger : MonoBehaviour
{
    public List<GameObject> objectsToDisappear;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Sprawd�, czy d�wignia zosta�a uderzona przez pocisk
        if (collision.gameObject.CompareTag("Projectile"))
        {
            // Ukryj ka�dy obiekt z listy
            foreach (GameObject obj in objectsToDisappear)
            {
                obj.SetActive(false);
            }

            // Mo�esz doda� dodatkow� logik�, np. zniszczenie pocisku
            Destroy(collision.gameObject);
        }
    }
}
