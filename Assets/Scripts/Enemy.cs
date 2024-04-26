using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Character
{
    public string enemyName;
    public float speed;
    private Health healthPoints;
    public override void Move()
    {


    }

    public void Shoot()
    {

    }

    public override void Die()
    {

    }

    public override void Attack()
    {
        Debug.Log("This enemy is throwing rocks at the player");
    }

    public Enemy(float speed, int health)
    {
        this.speed = speed;
        healthPoints = new Health(health);
    }

    public Enemy(string newEnemyName) : base("Wrong Name")
    {
        enemyName = newEnemyName;
    }

}
