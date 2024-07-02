using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class webRefill : MonoBehaviour
{
    GameObject player;
    [SerializeField] float web;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player") && web <1)
        {
            StartCoroutine("Refill");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            StopCoroutine("Refill");
        }
    }

    IEnumerator Refill()
    {
        for(float CurrentWeb = web; CurrentWeb <=1; CurrentWeb +=0.005f)
        {
            web -= CurrentWeb;
            yield return new WaitForSeconds(Time.deltaTime);
        }
        web = 1f;
    }
}
