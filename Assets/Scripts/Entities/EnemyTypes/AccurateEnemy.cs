//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class AccurateEnemy : Enemy
//{
//   public Weapon1 accurateWeapon;
//    public Health health; 
//    public float speed;
//    private weapon weapon;
//    private float newSpeed;
//    private int strength;
//    private int healthpoint;

//   public void Move(Vector2 direction)
//    {
//        speed = 10;
//        Debug.Log("The enemy is moving");
//        // speed is used here
//    }

//    public void Shoot()
//    {
//        Debug.Log("The player is attacking.");
//    }
//    public void Die()
//    {
//        Debug.Log("The player has died.");
//   }

//   public void Attack()
//    {

//   }

//   public void Move() { }

//    public AccurateEnemy(string enemyName) : base(enemyName)
//    {
//    }

//    public AccurateEnemy(int newSpeed, weapon newWeapon, "AccurateEnemy") // executed everytime new Player is created. 
//    {
//      speed = newSpeed;
//       weapon = newWeapon;
//       health = new Health();
//    }

//   public AccurateEnemy(float speedParameter, weapon weapon)
//    {

//        speed = Utilities.SumUpNumbers(2, 5) + speedParameter;
        
//        speed = newSpeed;
//        weapon = new Weapon();
//        this.weapon = weapon;

//        health = new Health();
//    }

//}


