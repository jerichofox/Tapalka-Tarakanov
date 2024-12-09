using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Image[] healthBarSprites;
    public int maxHealth = 5;
    public int currentHealth;

    public GameManager gameManager;

    private void Start()
    {
        InitializeHealthBar();
    }

    void InitializeHealthBar()
    {
        for (int i = 0; i < maxHealth; i++)
        {
            healthBarSprites[i].gameObject.SetActive(true);
        }
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        UpdateHealthBar();

        CheckIfGameShouldEnd();
    }

    void UpdateHealthBar()
    {
        for (int i = 0; i < maxHealth; i++)
        {
            bool shouldBeActive = i < currentHealth;
            healthBarSprites[i].gameObject.SetActive(shouldBeActive);
        }
    }

    void CheckIfGameShouldEnd()
    {
        if (currentHealth <= 0)
        {
            gameManager.StartGameOverSequences();
        }
    }
}
