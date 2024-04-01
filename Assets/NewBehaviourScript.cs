using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private GameObject square;
    private Vector3 scaleChange, positionChange;
    private Vector3 initialScale;

    void Start()
    {
        initialScale = transform.localScale;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            square.transform.localScale = new Vector3(0.5f, 3f, 1);
        }
        
        if (Input.GetKeyUp(KeyCode.R))
        {
            square.transform.localScale = new Vector3(3f, 0.5f, 1);
        }
    }

}