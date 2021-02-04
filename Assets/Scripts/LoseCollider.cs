using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    HealthDisplay healthDisplay;

    private void Start()
    {
        healthDisplay = FindObjectOfType<HealthDisplay>();
    }

    private void OnTriggerEnter2D()
    {
        healthDisplay.RemoveHealth(1);
    }
}
