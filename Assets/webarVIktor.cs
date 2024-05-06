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
        webText.text = "Web" + web + "%";
        if (web > maxWeb) web = maxWeb;

        lerpSpeed = 3f * Time.deltaTime;

        WebBarFiller();
        ColorChanger();

        if (Input.GetMouseButtonDown(0))
        {
            // Decrease health on mouse click
            web -= 10f;
            if (web <= 0f)
            {
                web = 0f;
                // Player is dead, you can handle this here
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
