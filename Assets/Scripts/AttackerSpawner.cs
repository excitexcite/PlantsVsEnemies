using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{

    bool spawn = true; // if true spawn attackers, otherwise stop spawning proccess
    [SerializeField] GameObject attackerPrefab; // field that represetns the attacker prefab
    [SerializeField] float mixSpawnTime = 1f; // minimum probable time between spawns
    [SerializeField] float maxSpawnTime = 5f; // maximum probable time between spawns


    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
            float time = Random.Range(mixSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(time);
            GameObject attacker = Instantiate(attackerPrefab,
                transform.position,
                Quaternion.identity) as GameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
