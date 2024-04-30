using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebBar : MonoBehaviour
{
    public Slider WebSlider;
    public static float Web;
    float maxWeb = 100f;


    private void Start()
    {
        Web = maxWeb;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Web -= 20f;
            WebSlider.value = Web;
        }

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("mucha"))
        {

            Web += 20f;
            WebSlider.value = Web;
            Destroy(other.gameObject);
        }
    }
}
