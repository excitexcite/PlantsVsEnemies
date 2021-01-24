using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{

    Defender defender; // object that represents the defender object

    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;
    }

    // when we click mouse button this method work
    private void OnMouseDown()
    {
        SpawnDefender(GetSquareClicked());
        //Debug.Log("Mouse was clicked");
    }

    // getting the click`s position
    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y); // get the click`s position in screen dimention
        //Debug.Log(clickPos);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos); // convert position to World Point
        Vector2 gridPos = SnapToGrid(worldPos);
        //Debug.Log(worldPos);
        return gridPos;
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        // round mouse click cordinates
        float newX = Mathf.RoundToInt(rawWorldPos.x); 
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

    private void SpawnDefender(Vector2 roundedPos)
    {
        // creating defender at a grid cell
        Defender newDefender = Instantiate(defender, roundedPos, Quaternion.identity);
    }
}
