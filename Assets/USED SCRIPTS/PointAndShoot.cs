using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PointAndShoot : MonoBehaviour
{
    public Image webBar;
    public TextMeshProUGUI webText;
    public GameObject crosshairs;
    public GameObject player;
    public GameObject webPrefab;
    public GameObject webStart;

    public float webSpeed = 60.0f;
    public float maxWeb = 100f;
    public float webUsagePerShot = 10f;
    private Vector3 target;
    private float web;

    private void Start()
    {
        Cursor.visible = false;
        web = maxWeb;
    }

    private void Update()
    {
        UpdateWebUI();
        HandleWebShooting();
    }

    private void UpdateWebUI()
    {
        webText.text = "Web " + Mathf.Clamp(web, 0, maxWeb) + "%";
        webBar.fillAmount = Mathf.Lerp(webBar.fillAmount, web / maxWeb, 3f * Time.deltaTime);
        webBar.color = Color.Lerp(Color.red, Color.white, web / maxWeb);
    }

    private void HandleWebShooting()
    {
        target = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
        crosshairs.transform.position = new Vector2(target.x, target.y);

        Vector3 difference = target - player.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        if (Input.GetMouseButtonDown(0) && web >= webUsagePerShot)
        {
            float distance = difference.magnitude;
            Vector2 direction = difference / distance;
            direction.Normalize();
            FireWeb(direction, rotationZ);
        }

        web = Mathf.Clamp(web, 0, maxWeb);
    }

    private void FireWeb(Vector2 direction, float rotationZ)
    {
        GameObject webInstance = Instantiate(webPrefab, webStart.transform.position, Quaternion.Euler(0.0f, 0.0f, rotationZ));
        webInstance.GetComponent<Rigidbody2D>().velocity = direction * webSpeed;

        Web webComponent = webInstance.AddComponent<Web>();
        webComponent.pointAndShoot = this;

        web -= webUsagePerShot;
    }

    public void IncreaseWeb(float amount)
    {
        web += amount;
        web = Mathf.Clamp(web, 0, maxWeb);
        UpdateWebUI();
    }

}
public class Web : MonoBehaviour
{
    public PointAndShoot pointAndShoot;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("fly2"))
        {
            Debug.Log("Trafiono w muchê!");
            pointAndShoot.IncreaseWeb(30f); // Zwiêksz web o 20

        }
    }
}

