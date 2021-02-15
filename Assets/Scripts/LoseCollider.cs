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

    private void OnTriggerEnter2D(Collider2D collider)
    {
        healthDisplay.RemoveHealth(1);
        Destroy(collider.gameObject);
    }
}
