using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class webarVIktor : MonoBehaviour
{
    public Image webBar;
    public TextMeshProUGUI webText;
    float lerpSpeed;

    float web, maxWeb = 100;

    private void Start()
    {
        web = maxWeb;
    }

    private void Update()
    {
        webText.text = "Web" + web + "%"; // odno�nik do tekstu w scenie i ustawienie pokazywania procent�w
        if (web > maxWeb) web = maxWeb; // je�li poziom sieci jest wi�kszy od maksymalnego to ustaw na maksymalny a nie wy�ej

        lerpSpeed = 3f * Time.deltaTime; // ustawienie p�ynno�ci zmiany paska sieci

        WebBarFiller();
        ColorChanger(); // zmiana koloru paska

        if (Input.GetMouseButtonDown(0))
        {
            // je�li zostanie przyci�ni�ty lewy przycisk myszy to:
            web -= 10f; // zmniejsz poziom sieci o 10
            if (web <= 0f) // je�li poziom sieci jest ni�szy ni� 0 to:
            {
                web = 0f;
                // ustaw poziom sieci na 0
            }
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            web += 10f;
        }
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

    public void WebUse(float webPoints)
    {
        if (web > 0)
            web -= webPoints;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("fly"))
        {
            // Destroy the player when it collides with a fly
            Destroy(gameObject); // Destroy the player GameObject
        }
    }
}
