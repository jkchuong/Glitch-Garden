using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    int attackersSpawned = 0;
    bool levelTimerFinished = false;

    public void AttackerSpawned()
    {
        attackersSpawned++;
    }

    public void AttackerKilled()
    {
        attackersSpawned--;
        if (attackersSpawned <= 0 && levelTimerFinished)
        {
            Debug.Log("End Level Now");
        }
    }

    public void LevelTimerFinished()
    {
        levelTimerFinished = true;
        StopSpawners();
    }

    private void StopSpawners()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in spawners)
        {
            spawner.StopSpawning();
        }

    }
}
