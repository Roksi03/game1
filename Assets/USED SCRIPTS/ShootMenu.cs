using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class ShootMenu : MonoBehaviour
{
    public GameObject webPrefab;
    public Transform shootPoint;
    public float webSpeed = 20f; // Zwiêkszona prêdkoœæ strza³u
    public Transform crosshairs;
    public GameObject player;
    private Vector3 target;

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
        Cursor.visible = false;
    }

    void Update()
    {
        // Aktualizacja pozycji celownika
        target = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, mainCamera.nearClipPlane));
        target.z = 0f; // Upewnienie siê, ¿e target jest w p³aszczyŸnie 2D
        crosshairs.transform.position = new Vector2(target.x, target.y);

        // Strzelanie sieci¹
        if (Input.GetMouseButtonDown(0))
        {
            ShootWeb(target);
        }
    }

    void ShootWeb(Vector3 targetPosition)
    {
        Vector3 direction = (targetPosition - shootPoint.position).normalized;

        // Instantiowanie sieci
        GameObject web = Instantiate(webPrefab, shootPoint.position, Quaternion.identity);

        // Ustawienie rotacji sieci
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        web.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

        // Nadanie prêdkoœci sieci
        web.GetComponent<Rigidbody2D>().velocity = direction * webSpeed;
    }
}