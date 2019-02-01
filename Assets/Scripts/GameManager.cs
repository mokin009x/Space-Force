using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> zombiesList;
    //public List<Zombies> zombiesList;

    private void Update()
    {
        if (zombiesList.Count < 0)
            Debug.Log("GameEnded");
    }

}
