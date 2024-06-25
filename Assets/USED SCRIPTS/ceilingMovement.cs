using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ceilingMovement : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision CollisionInfo)
    {

        Debug.Log(CollisionInfo.collider.name);

        if (CollisionInfo.collider.tag == "ceiling")
        {
            rb.isKinematic = true;

        }


    }

}
