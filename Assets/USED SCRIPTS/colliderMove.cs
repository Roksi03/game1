using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderMove : MonoBehaviour
{
    public Transform colliderTransform;

    void Update()
    {
        if (colliderTransform != null)
        {
            colliderTransform.position = transform.position;
            colliderTransform.rotation = transform.rotation;
        }
    }
}
