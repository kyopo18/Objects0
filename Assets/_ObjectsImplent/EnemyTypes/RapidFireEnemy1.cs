using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RapidFireEnemy1 : Enemy1
{
    public RapidFireEnemy1(string enemyName1) : base(enemyName1)
    {
    }

    protected override void Start()
    {
        base.Start();
        target = FindObjectOfType<Player1>();
        healthPoints.OnHealthChanged.AddListener(ChangedHealth);
        enemyWeapon = new Weapon1(base.bulletPrefab); // Activity Diagram : set weapon
    }

    //override attack and shoot from enemy
    //or just change weapon in prefab not script
    //logic in weapon



   
}
