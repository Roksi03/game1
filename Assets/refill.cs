using UnityEngine;
using UnityEngine.UI;

public class refill : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public Image healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("fly") && !other.isTrigger)
        {
            // Increment health by a certain amount when player touches a fly
            currentHealth += 10f;
            if (currentHealth > maxHealth)
            {
                currentHealth = maxHealth;
            }
            UpdateHealthBar();
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Decrease health on mouse click
            currentHealth -= 10f;
            if (currentHealth <= 0f)
            {
                currentHealth = 0f;
                // Player is dead, you can handle this here
            }
            UpdateHealthBar();
        }
    }

    void UpdateHealthBar()
    {
        // Update the health bar UI
        healthBar.fillAmount = currentHealth / maxHealth;
    }
}