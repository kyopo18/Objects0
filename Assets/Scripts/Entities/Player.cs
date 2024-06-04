using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{    
    private bool hasNuke = false;
    protected override void Start()
    {
        base.Start();
    }
    public override void Attack() // base attack
    {
        weapon.ShootMe(transform, "Enemy"); //OTHER WORKING LINE for bullet inside player
        SoundManager.Instance.PlayShootSound(transform.position);
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
    public void OnFireRatePickup(float duration)
    {

    }
    public void OnHealthPickup(int heal)
    {
        healthPoints.IncreaseLife(heal);
        SoundManager.Instance.PlayPickupSound(transform.position);
    }
    public void OnNukePickup()
    {
        if(!hasNuke)
        {
            hasNuke = true;
        }
    }
    public void OnShieldPickup(int shieldAmount)
    {
        healthPoints.AddShield(shieldAmount);
    }
    public void UseNuke()
    {
        if(hasNuke)
        {
            GameManager.singleton.OnNuke();
        }
    }
}
