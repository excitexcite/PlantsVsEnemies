using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] int health = 100;
    [SerializeField] float deathVFXDuration = 1f; // duration of death visual effects
    [SerializeField] GameObject deathVSX; // death visual effects prefab

    // this method works when projectile collides attacker
    public void DealDamage(int gamage) 
    { 
        health -= gamage; 
        // when attacker health points equals zero
        if (health <= 0)
        {
            TriggerDeathVFX(); // show deathVFX
            Destroy(gameObject); // destroy attacker
        }
    }

    private void TriggerDeathVFX()
    {
        if (!deathVSX) { return; } // if there is no visual effects prefab on some reason, do not attemp to show them
        GameObject deathVFXObject = Instantiate(deathVSX, transform.position, Quaternion.identity);
        Destroy(deathVFXObject, deathVFXDuration);
    }
}
