/*using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health
{

    public int maxHealth = 100;
    public int currentHealth = 100;

    public Health(int health)
    {
        //Health = health;
    }

    //public int Health { get; }

    //public Health(int maxHealth);
    //{
    //   currentHealth = maxHealth;
    //}
    public void DecreaseLife()
    {

    }

    public void IncreaseLife()
    {

    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        // if health is 0
        // spawn damage effect
    }

    public void Heal()
    {
        //currentHealth += heal;
    }

    public static implicit operator Health(Health1 v)
    {
        throw new NotImplementedException();
    }
}

//// Example
//public class FrameScore
//{
//    public int firstThrow;
//    public int secondThrow;
//    public int totalScore;
//}
*/