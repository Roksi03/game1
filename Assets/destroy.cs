using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Mo�esz doda� dodatkowe warunki, je�li chcesz zniszczy� obiekt tylko w przypadku okre�lonych kolizji
       
        Destroy(gameObject);
    }
}
