using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    internal Character target;
    internal int damage;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(target.tag))
        {
            //DO Damage to enemy
            collision.gameObject.GetComponent<IDamageable>().ReceiveDamage(damage);
            Debug.Log("Its hitting!");
        }
    }
}
