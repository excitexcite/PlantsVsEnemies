using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{

    int attackersNumber = 0; // current number of attacker
    bool levelTimerFinished = false; // if the timer end or not

    // function that allows to increase number of currently spawned attackers
    public void AttackerSpawned()
    {
        attackersNumber++;
    }

    // function that allows to decrease number of currently spawned attackers
    public void AttackerKilled()
    {
        attackersNumber--;
        if (attackersNumber <= 0 && levelTimerFinished)
        {
            Debug.Log("End game right now");
        }
    }

    public void LevelTimerFinished()
    {
        levelTimerFinished = true;
        StopSpawners();
    }

    private void StopSpawners()
    {
        AttackerSpawner[] spawnerArray = FindObjectsOfType<AttackerSpawner>();
        foreach(AttackerSpawner spawner in spawnerArray)
        {
            spawner.StopSpawning();
        }
    }
}
