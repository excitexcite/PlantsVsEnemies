using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{

    [SerializeField] int stars = 100; // initial amount of starts
    Text starTest;

    // Start is called before the first frame update
    void Start()
    {
        starTest = GetComponent<Text>(); // get obect`s text component
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        starTest.text = stars.ToString(); // converts int value (amount of start) to string to display it
    }

    public void AddStars(int amount)
    {
        stars += amount; // add start when we earn them some way
        UpdateDisplay(); // update stars text
    }

    // this method checks if we have enough stars to place defender
    public bool HaveEnoughtStars(int amount)
    {
        return stars >= amount;
    }

    public void SpendStars(int amount)
    {
        if (stars < amount) { return; } // if we do not have enough stars to spend use return command to exit this function
        // otherwise decrease amount of stars and update stars text
        stars -= amount;
        UpdateDisplay(); 
    }
}
