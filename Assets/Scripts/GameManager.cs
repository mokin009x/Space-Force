using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Zombie Hekzombie;
    public Transform player;
    //public List<GameObject> zombiesList;
    public List<Zombie> zombiesList;

    private void Update()
    {
        if (zombiesList.Count < 0)
            Debug.Log("GameEnded");
    }

    private void OnEnable()
    {
        Hekzombie.damage = 100;
        Instantiate(Hekzombie, player, false);
    }

}
