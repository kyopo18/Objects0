using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{    protected override void Start()
    {
        base.Start();
    }
    public override void Attack() // base attack
    {
        weapon.ShootMe(transform, "Enemy"); //OTHER WORKING LINE for bullet inside player
    }
    public override void Die()
    {
        GameManager.singleton.EndGame();
        Destroy(gameObject);
    }

    public override void ReceiveDamage()
    {
        healthPoints.DecreaseLife();
        Debug.Log("LOST HEALTH. CURRENT HEALTH: " + healthPoints.currentHealth);
    }
}
