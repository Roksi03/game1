using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class arm : MonoBehaviour
{
    public float rotationSpeed = 30f; // Pr�dko�� obrotu postaci
    private Quaternion initialRotation; // Pocz�tkowa rotacja postaci

    void Start()
    {
        initialRotation = transform.rotation;
    }

    void Update()
    {
        // Sprawdzenie czy klawisz "R" jest naci�ni�ty
        if (Input.GetKey(KeyCode.R))
        {
            // Obr�� posta� w g�r�
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
        else
        {
            // Powr�� do pocz�tkowej rotacji postaci
            transform.rotation = Quaternion.Lerp(transform.rotation, initialRotation, Time.deltaTime);
        }
    }
    
}
  





