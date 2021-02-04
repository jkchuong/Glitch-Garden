using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] int health = 20;
    Text healthText;

    void Start()
    {
        healthText = GetComponent<Text>();
        UpdateDisplay();
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
            FindObjectOfType<LevelLoader>().LoadLoseScreen();
        }
    }
}
