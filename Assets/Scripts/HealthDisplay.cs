using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] int health = 100; // initial amount of health point
    [SerializeField] int damage = 1; // amount that user lose when attacker got to the end of the gamefield
    Text healthText;

    // Start is called before the first frame update
    void Start()
    {
        healthText = GetComponent<Text>(); // get obect`s text component
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        healthText.text = health.ToString(); // converts int value (health) to string to display it
    }

    public void AddHealth(int amount)
    {
        health += amount; // add start when we earn them some way
        UpdateDisplay(); // update health text
    }

    // this method checks if we have health points to continue playing
    public bool HaveEnoughtHealth(int amount)
    {
        return health >= amount;
    }

    public void LoseHealth()
    {
        // otherwise decrease amount of health by damage value
        health -= damage;
        UpdateDisplay();

        if (health <= 0)
        {
            FindObjectOfType<LevelLoader>().LoadLoseScreen();
        }

    }
}
