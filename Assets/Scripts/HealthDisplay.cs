using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] int baseHealth = 20;

    int health;
    Text healthText;

    void Start()
    {
        health = baseHealth - (PlayerPrefsController.GetDifficulty() * 2);
        healthText = GetComponent<Text>();
        UpdateDisplay();
        Debug.Log("Difficulty: " + PlayerPrefsController.GetDifficulty());
    }

    private void UpdateDisplay()
    {
        healthText.text = health.ToString();
    }

    public void RemoveHealth(int amount)
    {
        health -= amount;
        UpdateDisplay();
        if (health <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }
}
