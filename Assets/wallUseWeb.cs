using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class wallUseWeb : MonoBehaviour
{
    public float web, maxWeb = 100;

    public TextMeshProUGUI webText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "wall")
        {
            web -= 10f; // zmniejsz poziom sieci o 10
            if (web <= 0f) // je�li poziom sieci jest ni�szy ni� 0 to:
            {
                web = 0f;
            }

            Debug.Log("test");

            webText.text = "Web" + web + "%"; // odno�nik do tekstu w scenie i ustawienie pokazywania procent�w
            if (web > maxWeb) web = maxWeb;
        }
    }
}
