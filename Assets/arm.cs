using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class arm : MonoBehaviour
{
    public float rotationSpeed = 30f; // Prêdkoœæ obrotu postaci
    private Quaternion initialRotation; // Pocz¹tkowa rotacja postaci

    void Start()
    {
        initialRotation = transform.rotation;
    }

    void Update()
    {
        // Sprawdzenie czy klawisz "R" jest naciœniêty
        if (Input.GetKey(KeyCode.R))
        {
            // Obróæ postaæ w górê
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
        else
        {
            // Powróæ do pocz¹tkowej rotacji postaci
            transform.rotation = Quaternion.Lerp(transform.rotation, initialRotation, Time.deltaTime);
        }
    }
    
}
  





