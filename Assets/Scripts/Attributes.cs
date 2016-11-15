﻿using UnityEngine;

public class Attributes : MonoBehaviour {

    [SerializeField] private int initialHealth;

    private int health;
    public int Health
    {
        get { return health; }
        set { health = Mathf.Clamp(value, 0, initialHealth); }
    }

    [SerializeField] private int minDamage;
    [SerializeField] private int maxDamage;

    private int damage;
    public int Damage
    {
        get { return damage; }
        set { damage = Mathf.Clamp(value, minDamage, maxDamage); }
    }

    public virtual void Init()
    {
        Health = initialHealth;
        Damage = (minDamage + maxDamage) / 2;
    }
}
