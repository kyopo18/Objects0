//using System.Collections;
//using System.Collections.Generic;
//using UnityEditor.SceneManagement;
//using UnityEngine;

//public class Player : Character
//{
//    public Weapon weapon;
//    public Health health; 
//    public float speed;
//    private float newSpeed;
//    private int strength;
//    private int healthpoint;
    
//    public void Move(Vector2 direction)
//    {
//        speed = 10;
//        Debug.Log("The player is moving");
//        // speed is used here
//    }

//    public void Shoot()
//    {
//        Debug.Log("The player is attacking.");
//    }

//    public void Die()
//    {
//        Debug.Log("The player has died.");
//    }

//    public override void Attack()
//    {
        
//    }

//    public override void Move()
//    {
        
//    }

//    public Player(int newSpeed, Weapon newWeapon) // executed everytime new Player is created. 
//    {
//        speed = newSpeed;
//        weapon = newWeapon;
//        //health = new Health();
//    }

//    public Player(float speedParameter)
//    {

//        speed = Utilities.SumUpNumbers(2, 5) + speedParameter;
//        //Debug.Log(LevelLoader.difficulty);
//        speed = newSpeed;
//        weapon = new Weapon();
//        //health = new Health();
//    }

//}


