using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    [SerializeField] float moveSpeed = 1f; // move speed of the projectile
    [SerializeField] int damage = 50; // damage that takes the projectile

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
    }

    // when the projectile collides to the other object (attacker) this method works
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        // get the Health component from the Attacker`s gameobject
        var health = otherCollider.GetComponent<Health>();
        var attacker = otherCollider.GetComponent<Attacker>();
        if (health && attacker) // if attacker`s gameobject has both Health and Attacker components we do something
            // otherwise such gameobject is not a correct instance of enemy
        {
            health.DealDamage(damage); // tell the game object to decrease health by gamage value
            Destroy(gameObject); // destroyed projectile gameobject after hit
        }
       
    }
}
