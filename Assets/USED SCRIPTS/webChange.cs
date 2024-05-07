using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class webChange : MonoBehaviour
{
    [SerializeField] private GameObject webChanger;
    [SerializeField] private GameObject webChangerTarget;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(webChanger, transform.position, Quaternion.identity);
        Destroy(webChangerTarget);
    }
}
