﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    
    [Range (0f, 5f)] // adds a slider in unity to adjust attacker speed
    [SerializeField] float moveSpeed = 1f; // the default attacker speed value
    GameObject currentTarget;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }

    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("IsAttacking", true);
        currentTarget = target;
    }

    public void SetMovementSpeed(float speed) { moveSpeed = speed; }

}
