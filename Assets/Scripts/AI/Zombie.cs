using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public int health, damage, lookRange;
    public Transform target;
    public bool isChasing;

    public Zombie(int _health, int _damage, int _lookRange, Transform _target, bool _isChasing)
    {
        health = _health;
        damage = _damage;
        lookRange = _lookRange;
        target = _target;
        isChasing = _isChasing;
    }
}
