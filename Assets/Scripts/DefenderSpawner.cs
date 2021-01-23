using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{

    [SerializeField] GameObject defender; // prefab that represents the defender object

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // when we click mouse button this method work
    private void OnMouseDown()
    {
        SpawnDefender(GetSquareClicked());
        Debug.Log("Mouse was clicked");
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
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

    private void SpawnDefender(Vector2 roundedPos)
    {
        
        GameObject newDefender = Instantiate(defender, roundedPos, Quaternion.identity);
    }
}
