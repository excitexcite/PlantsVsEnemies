using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    [SerializeField] int timeToWait = 4; // time to wait for the screen load
    private int currentScreenIndex; // the index of the current scene

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start() method");
        // 0 for the splash screen, other for other screens
        currentScreenIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentScreenIndex == 0)
        {
            StartCoroutine(waitAndLoad());
        }        
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentScreenIndex + 1);
    }

    IEnumerator waitAndLoad()
    {
        Debug.Log("waitAndLoad() method");
        yield return new WaitForSeconds(timeToWait);
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
