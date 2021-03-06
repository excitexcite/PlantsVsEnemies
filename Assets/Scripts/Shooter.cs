﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    [SerializeField] GameObject projectile; // prefab that represens a projectile
    [SerializeField] GameObject gun; // empty game object that is placed where the projectile has to be instatiated
    AttackerSpawner myLaneSpawner; // the line, which is the same to the attacker`s lane
    Animator animator; // animator object that allows us to control animation events

    // Start is called before the first frame update
    void Start()
    {
        SetLaneSpawner();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // if there is an attacker on the line defender stars to attack
        if (IsAttackerInLane())
        {
            //Debug.Log("shoot pew pew");
            animator.SetBool("IsAttacking", true); // gettuing bool condition from the animator in unity
        }
        // otherwise defender starts to do his default animation
        else
        {
            //Debug.Log("sit and wane");
            animator.SetBool("IsAttacking", false);
        }
    }

    public void Fire()
    {
        Instantiate(projectile, gun.transform.position, Quaternion.identity);
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in spawners)
        {
            if (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon)
            {
                myLaneSpawner = spawner;
            }
        }
    }

    private bool IsAttackerInLane()
    {
        if (myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
