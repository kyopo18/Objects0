using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserEnemy : Enemy
{
    protected override void Start()
    {
        base.Start();
    }
    public override void Attack()
    {
        weapon.ShootMe(transform, "Player");
    }



    //public AccurateEnemy(int newSpeed, Weapon newWeapon, string "AccurateEnemy") // executed everytime new Player is created. 
    //{
    //    speed = newSpeed;
    //    weapon = newWeapon;
    //    health = new Health();
    //}

    //public LaserEnemy(float speedParameter, Weapon weapon) 
    //{

    //    newSpeed = speedParameter;
    //    weapon = new Weapon();
    //    enemyWeapon = weapon;

    //    health = new Health();
    //}

}


