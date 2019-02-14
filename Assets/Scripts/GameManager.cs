using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Hekzombie;
    static GameManager instance;
    int canSpawn = 0;
    //public List<GameObject> zombiesList;
    public List<GameObject> zombiesList;
    public List<GameObject> spawnPoints;

    private void Awake()
    {
        instance = this;
    }

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
        Instantiate(Hekzombie, spawnPoints[Random.Range(0, spawnPoints.Count)].transform, false);
        zombiesList.Add(Hekzombie);
        yield return new WaitForSeconds(1);
        if (canSpawn <= 20)
        {
            canSpawn++;
            StartCoroutine("Spawner");
        }
    }

}
