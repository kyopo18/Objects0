using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    //[SerializeField] private Transform aim;
    //[SerializeField] private Bullet1 bulletPrefab;

    protected override void Start()
    {
        base.Start();
    }
    public override void Attack() // base attack
    {
        
        //playerWeapon.ShootMe(aim.position, aim.rotation, "Enemy"); // Accurate Aim add aim and bulletspawn empties to player
        weapon.ShootMe(transform, "Enemy"); //OTHER WORKING LINE for bullet inside player
    }

    //public override void Attack(1) // Highly accurate attack
    //{
        // Fix me.
      //  playerWeapon.ShootMe(transform.position);
    //}

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
