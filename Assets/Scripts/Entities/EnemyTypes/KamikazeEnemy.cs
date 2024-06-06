
using System;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class KamikazeEnemy : Enemy
{       
    public int damage = 10;                // Amount of damage to deal to the player on collision
    public GameObject explosionEffect;     // Prefab for the explosion effect

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collided object is the player
        if (collision.CompareTag("Player"))
        {
            // Damage the player
            collision.GetComponent<IDamageable>().ReceiveDamage(damage);
            Debug.Log("Its hitting!");

            // Create an explosion effect
            if (explosionEffect != null)
            {
                Instantiate(explosionEffect, transform.position, transform.rotation);
            }

            // Destroy the enemy
            Destroy(gameObject);
        }
    }
}

    //public override void Attack()
    //{
    //    //    //weapon.ShootMe(transform, "Player"); <----this is an example of working machinegun enemy
    //    //    weapon.ExplodeMe(transform, "Player");
    //    ExplodeMe();
    //}

    //private void OnCollisionEnter(Collision collision)
    //{
    //    // Check if the collided object has the "Player" tag
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        // Call the ExplodeMe function to handle the explosion
    //        ExplodeMe();
    //    }
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    // Check if the collided object has the "Player" tag
    //    if (other.gameObject.CompareTag("Player"))
    //    {
    //        // Call the ExplodeMe function to handle the explosion
    //        ExplodeMe();
    //    }
    //}

    //private void ExplodeMe()
    //{
       
    //    // Optionally, destroy the enemy game object after the explosion
    //    Destroy(gameObject);
    //}

   

    ////public virtual void ReceiveDamage()
    ////{
    ////    healthPoints.DecreaseLife();
    ////}

    ////public virtual void ReceiveDamage(int damage)
    ////{
    ////    healthPoints.DecreaseLife(damage);
    ////}



