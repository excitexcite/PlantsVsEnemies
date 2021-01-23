using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] int health = 100;
    [SerializeField] float deathVFXDuration = 1f;
    [SerializeField] GameObject deathVSX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DealDamage(int gamage) 
    { 
        health -= gamage; 
        if (health <= 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
        }
    }

    private void TriggerDeathVFX()
    {
        if (!deathVSX) { return; }
        GameObject deathVFXObject = Instantiate(deathVSX, transform.position, Quaternion.identity);
        Destroy(deathVFXObject, deathVFXDuration);
    }
}
