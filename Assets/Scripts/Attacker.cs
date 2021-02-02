using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [Range (0f, 5f)]
    float currentSpeed = 1f;
    [SerializeField] int health = 5;
    [SerializeField] GameObject deathVFX;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * currentSpeed);
    }

    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Projectile"))
        {
            Projectile projectile = collision.GetComponent<Projectile>();
            health -= projectile.DoDamage();
            if (health <= 0)
            {
                TriggerDeathVFX();
                Destroy(gameObject);
            }
        }
    }

    private void TriggerDeathVFX()
    {
        if (!deathVFX) { return; }
        GameObject deathVFXObject = Instantiate(deathVFX, transform.position - (transform.right * 0.4f) + (transform.up * 0.5f), transform.rotation);
        Destroy(deathVFXObject, 1f);
    }
}
