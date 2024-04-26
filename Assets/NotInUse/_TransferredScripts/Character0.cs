using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character0 : MonoBehaviour
{
    // HotDog's Default Attributes:
    public HealthManager0 healthPoints; // Player0's Default Health Bar.
    [SerializeField] private float speed; // Player0's Default Walking Speed.
 
   
    [SerializeField] private int fireRate; // Player0's Default Rate Of Fire based on his Training and Experience.



    public abstract void RangedAttack();


    public abstract void DeadMeat();


    public abstract void Move();
   
    public Character0()
    {

    }
    public Character0(HealthManager0 healthPoints, float speed, int fireRate, float morale)
    {
        this.healthPoints = healthPoints;
        this.speed = speed;
        this.fireRate = fireRate;
        
        
        
    }
}
