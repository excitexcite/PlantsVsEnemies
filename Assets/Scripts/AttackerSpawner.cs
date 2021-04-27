using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{

    bool spawn = true; // if true spawn attackers, otherwise stop spawning proccess
    [SerializeField] Attacker[] attackerPrefabArray; // field that represetns the attacker prefab
    [SerializeField] float mixSpawnTime = 1f; // minimum probable time between spawns
    [SerializeField] float maxSpawnTime = 5f; // maximum probable time between spawns


    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
            float time = Random.Range(mixSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(time);
            SpawnAttackers();
        }
    }

    private void SpawnAttackers()
    {
        int attackerIndex = UnityEngine.Random.Range(0, attackerPrefabArray.Length);
        Spawn(attackerPrefabArray[attackerIndex]);
        
    }

    public void StopSpawning()
    {
        spawn = false;
    }

    private void Spawn(Attacker myAttacker)
    {
        Attacker newAttacker = Instantiate(myAttacker,
            transform.position,
            Quaternion.identity);
        newAttacker.transform.parent = transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
