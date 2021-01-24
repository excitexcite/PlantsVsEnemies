using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderButton : MonoBehaviour
{

    [SerializeField] Defender defenderPrefab; // defender that was selected by mouse click

    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderButton>(); // found all buttons-defender types
        foreach (DefenderButton button in buttons) // for each defender
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(41, 41, 41, 255); // change color to black (inactive)
        }
        gameObject.GetComponent<SpriteRenderer>().color = Color.white; // remove color change from selected defender
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab); // tell DefenderSpawner to spawn selected defender
    }

}
