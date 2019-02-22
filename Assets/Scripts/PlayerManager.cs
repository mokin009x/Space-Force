using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    public int playerPoints = 0;

    private void Awake()
    {
        instance = this;
    }
}
