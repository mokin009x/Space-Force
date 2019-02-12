using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Hekzombie;
    public Transform player;
    int canSpawn = 0;
    //public List<GameObject> zombiesList;
    public List<GameObject> zombiesList;

    private void Update()
    {
        if (zombiesList.Count < 0)
            Debug.Log("GameEnded");
    }

    private void OnEnable()
    {
        StartCoroutine("Spawner");
    }

    public IEnumerator Spawner()
    {
        Instantiate(Hekzombie, player, false);
        zombiesList.Add(Hekzombie);
        yield return new WaitForSeconds(3);
        if (canSpawn <= 5)
        {
            canSpawn++;
            StartCoroutine("Spawner");
        }
    }

}
