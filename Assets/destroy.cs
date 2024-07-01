using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Mo¿esz dodaæ dodatkowe warunki, jeœli chcesz zniszczyæ obiekt tylko w przypadku okreœlonych kolizji
       
        Destroy(gameObject);
    }
}
