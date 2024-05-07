using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float forcetoAdd = 100;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
            GetComponent<Rigidbody2D>().AddForce(-Vector2.right * forcetoAdd);

        if (Input.GetKey(KeyCode.D))
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * forcetoAdd);

    }
}
