using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{

    [SerializeField] float minTimeBetweenSpawn = 1f;
    [SerializeField] float maxTimeBetweenSpawn = 5f;
    [SerializeField] Attacker[] attackerPrefab;

    bool spawn = true;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(minTimeBetweenSpawn, maxTimeBetweenSpawn));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker()
    {
        int num = UnityEngine.Random.Range(0, attackerPrefab.Length);
        Attacker newAttacker = Instantiate(attackerPrefab[num], transform.position, transform.rotation) as Attacker;
        newAttacker.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
