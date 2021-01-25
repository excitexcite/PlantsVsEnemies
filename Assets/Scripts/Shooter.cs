using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    [SerializeField] GameObject projectile; // prefab that represens a projectile
    [SerializeField] GameObject gun; // empty game object that is placed where the projectile has to be instatiated
    AttackerSpawner myLaneSpawner; // 

    // Start is called before the first frame update
    void Start()
    {
        SetLaneSpawner();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsAttackerInLane())
        {
            Debug.Log("shoot pew pew");
        }
        else
        {
            Debug.Log("sit and wane");
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
