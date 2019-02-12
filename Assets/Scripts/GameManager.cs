using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Hekzombie;
    public Transform player;
    //public List<GameObject> zombiesList;
    public List<GameObject> zombiesList;

    private void Update()
    {
        if (zombiesList.Count < 0)
            Debug.Log("GameEnded");
    }

    private void OnEnable()
    {
        for (int i = 0; i < 5; i++)
        {
            Instantiate(Hekzombie, player, false);
            zombiesList.Add(Hekzombie);
        }
    }

}
