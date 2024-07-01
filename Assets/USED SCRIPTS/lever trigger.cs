using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levertrigger : MonoBehaviour
{
    public List<GameObject> objectsToDisappear;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // SprawdŸ, czy dŸwignia zosta³a uderzona przez pocisk
        if (collision.gameObject.CompareTag("Projectile"))
        {
            // Ukryj ka¿dy obiekt z listy
            foreach (GameObject obj in objectsToDisappear)
            {
                obj.SetActive(false);
            }

            // Mo¿esz dodaæ dodatkow¹ logikê, np. zniszczenie pocisku
            Destroy(collision.gameObject);
        }
    }
}
