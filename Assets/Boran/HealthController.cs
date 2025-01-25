using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public Slider healthBar; 
    public int maxHealth = 100;
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        if (currentHealth >= 100)
        {
            currentHealth = 100;
        }
        healthBar.value = currentHealth;
    }
    

    public void ChangeHealth(int amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHealthBar();
    }
}
