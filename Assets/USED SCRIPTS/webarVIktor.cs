using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class webarVIktor : MonoBehaviour
{
    public Image webBar;
    public TextMeshProUGUI webText;
    float lerpSpeed = 3f;

    float web, maxWeb = 100;

    private void Start()
    {
        web = maxWeb;
        UpdateWebUI();
    }

    private void Update()
    {
        if (web > maxWeb) web = maxWeb; // Upewnij siê, ¿e poziom sieci nie przekroczy maksymalnego

        if (Input.GetMouseButtonDown(0))
        {
            // Zmniejsz poziom sieci o 10 po klikniêciu lewego przycisku myszy
            web -= 10f;
            if (web < 0f) web = 0f; // Ustaw poziom sieci na 0, jeœli spadnie poni¿ej
            UpdateWebUI();
        }

        WebBarFiller();
        ColorChanger(); // Zmiana koloru paska
    }

    void WebBarFiller()
    {
        webBar.fillAmount = Mathf.Lerp(webBar.fillAmount, web / maxWeb, lerpSpeed * Time.deltaTime);
    }

    void ColorChanger()
    {
        Color webColor = Color.Lerp(Color.red, Color.white, web / maxWeb);
        webBar.color = webColor;
    }

    void UpdateWebUI()
    {
        webText.text = "Web " + web + "%";
        WebBarFiller();
        ColorChanger();
    }

    public void WebUse(float webPoints)
    {
        if (web > 0)
        {
            web -= webPoints;
            if (web < 0) web = 0;
            UpdateWebUI();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("fly"))
        {
            web += 10f;
            UpdateWebUI();
            if (web > maxWeb) web = maxWeb; // Upewnij siê, ¿e poziom sieci nie przekroczy maksymalnego
            Destroy(other.gameObject); // Zniszcz obiekt "fly" po kolizji
             // Zaktualizuj UI po zmianie poziomu sieci
        }
    }
}
