using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : Bullet
{
    
    private void Start()
    {
        enabled = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            //DO Damage to enemy
            collision.gameObject.GetComponent<IDamageable>().ReceiveDamage(damage);
            Debug.Log("Its hitting!");
        }
        return;
    }
}
