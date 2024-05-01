using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserEnemy : Enemy
{
    public Weapon enemyWeapon;
    public Health health;
    //[SerializeField] private float rateOfFire = 3f; //added this just now
    //public float speed;
    //private Weapon weapon; // 28/04/2024 0900
    private float enemySpeed = 10f; // 29/04/2024 0900
    //private int strength;
    //private int healthpoint;

    

    //protected override void Awake()
    //{
    //    base.Awake();
    //    intervalPerBullet = 3f;
    //}

    protected override void Start()
    {
        base.Start();
        
        
    }
    protected override void Move()
    {
        
        
        base.Move(); // 29/04/2024 0900 speed is used here
    }
    protected void Move(Vector2 direction)
    {
        
        
        // speed is used here
    }

    public override void Attack()
    {
        //Debug.Log("Enemy is attacking with LaserShooter.");
        ////enemyWeapon = ScriptableObject.CreateInstance<Weapon>();
        //enemyWeapon = ScriptableObject.CreateInstance<Weapon>();
        //if (target != null)
        //{
        //    transform.right = Vector3.Normalize(target.transform.position - transform.position);
        //    if (transform != null)
        //    {
        //        Debug.Log("Transform is Good.");
        //    }    

        //        if ( transform.right != null )
        //        { 
        //            enemyWeapon.ShootMe(transform, "Player");
                    
                    
        //        }
        //        else
        //        {
        //            Debug.Log("Transform is Bad.");
        //        }
        //}
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


