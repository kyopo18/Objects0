using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : Character1
{
    //[SerializeField] private Transform aim;
    //[SerializeField] private Bullet1 bulletPrefab;
    [SerializeField] private Weapon1 playerWeapon;

    protected override void Start()
    {
        
        rigidBody = GetComponent<Rigidbody2D>();
        healthPoints = new Health1(4);
        healthPoints.OnHealthChanged.AddListener(ChangedHealth);
        //playerWeapon = new Weapon1(bulletPrefab);
    }

    

    public void ChangedHealth(int health)
    {

        Debug.Log("LIFE HAS CHANGED TO " + health);
        if (health <= 0)
        {
            Die();
        }

    }

    public override void SetWeapon(Weapon1 newWeapon)
    {
        base.SetWeapon(newWeapon);
        playerWeapon = newWeapon;
    }
    public override void Attack() // base attack
    {
        
        //playerWeapon.ShootMe(aim.position, aim.rotation, "Enemy"); // Accurate Aim add aim and bulletspawn empties to player
        playerWeapon.ShootMe(transform.position, transform.rotation, "Enemy"); //OTHER WORKING LINE for bullet inside player
    }

    //public override void Attack(1) // Highly accurate attack
    //{
        // Fix me.
      //  playerWeapon.ShootMe(transform.position);
    //}

    public override void Die()
    {
        GameManager1.singleton.EndGame();

        Destroy(gameObject);
    }

    public override void Move(Vector2 direction, float angle)
    {
        base.Move(direction, angle);
    }

    public override void ReceiveDamage()
    {
        healthPoints.DecreaseLife();
        Debug.Log("LOST HEALTH. CURRENT HEALTH: " + healthPoints.currentHealth);
        

    }
}
