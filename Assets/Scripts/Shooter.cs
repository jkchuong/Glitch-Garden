using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile, gun;

    private void Update()
    {
        if (IsAttackerInLane())
        {
            Debug.Log("Shoot pew pew");
            // Change animation states
        }
        else
        {
            Debug.Log("Sit and wait");
        }
    }

    private bool IsAttackerInLane()
    {
        throw new NotImplementedException();
    }

    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, Quaternion.Euler(0, 0, 45));
    }
}
