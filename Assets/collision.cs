using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour

{
    [SerializeField] private GameObject spider;
    public GameObject Square;
    private Vector3 squarePosition;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ground")
            {
            spider.transform.position = squarePosition;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
