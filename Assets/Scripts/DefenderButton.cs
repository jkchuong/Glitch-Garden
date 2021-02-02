using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{
    private SpriteRenderer buttonSprite;
    private DefenderButton[] buttons;

    [SerializeField] Defender defenderPrefab;

    private void Start()
    {
        buttonSprite = GetComponent<SpriteRenderer>();
        buttons = FindObjectsOfType<DefenderButton>();
    }

    private void OnMouseDown()
    {
        foreach (DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(96, 96, 96, 255);
        }
        buttonSprite.color = Color.white;
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);
    }
}
