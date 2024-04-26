using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidFireEnemy : Enemy
{
    public RapidFireEnemy(string enemyName) : base(enemyName)
    {
    }

    protected override void Start()
    {
        base.Start();
        target = FindObjectOfType<Player>();
        healthPoints.OnHealthChanged.AddListener(ChangedHealth);
        enemyWeapon = new Weapon(); // Activity Diagram : set weapon
    }

    //override attack and shoot from enemy
    //or just change weapon in prefab not script
    //logic in weapon



   
}
