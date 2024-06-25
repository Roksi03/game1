using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class web : MonoBehaviour
{
    public PointAndShoot pointAndShoot;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("fly2"))
        {
            pointAndShoot.IncreaseWeb(pointAndShoot.maxWeb); // Refill web to max value
        }
    }
}
