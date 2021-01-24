using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{

    [SerializeField] int starCost = 100; // defender`s cost in stars

    // increasing the number of stars by amount-value
    public void AddStars(int amount)
    {
        FindObjectOfType<StarDisplay>().AddStars(amount);
    }

    // getting defender`s cost in stars
    public int GetStarCost() { return starCost; } 
}
