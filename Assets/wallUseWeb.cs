using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Windows.WebCam;
public class wallUseWeb : MonoBehaviour
{
    public float web, maxWeb = 100;

    float lerpSpeed;

    public Image webBar;

    public TextMeshProUGUI webText;

    private void Update()
    {
        lerpSpeed = 3f * Time.deltaTime;

        WebBarFiller();
        ColorChanger();
    }
    void WebBarFiller()
    {
        webBar.fillAmount = Mathf.Lerp(webBar.fillAmount, web / maxWeb, lerpSpeed);
    }

    void ColorChanger()
    {
        Color webColor = Color.Lerp(Color.red, Color.white, (web / maxWeb));

        webBar.color = webColor;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "wall")
        {
            web -= 10f; // zmniejsz poziom sieci o 10
            if (web <= 0f) // jeœli poziom sieci jest ni¿szy ni¿ 0 to:
            {
                web = 0f;
            }

            Debug.Log("test");

            webText.text = "Web" + web + "%"; // odnoœnik do tekstu w scenie i ustawienie pokazywania procentów
            if (web > maxWeb) web = maxWeb;
        }
    }
}
