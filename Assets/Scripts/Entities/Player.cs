using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{    
    private bool hasNuke = false;
    [SerializeField] float OriginalFireRate = 0.2f;
    private float currentFireRate;
    private IEnumerator BuffDuration;
    private bool hasFired;
    protected override void Start()
    {
        base.Start();
        currentFireRate = OriginalFireRate;
    }
    public override void Attack() // base attack
    {
        weapon.ShootMe(transform, "Enemy"); //OTHER WORKING LINE for bullet inside player
        SoundManager.Instance.PlayShootSound(transform.position);
    }
    public override void Die()
    {
        GameManager.singleton.EndGame();
        //ScoreManager1.singleton.DisplayHighScoreOnGameOver(); // Call the method to display high score
        Destroy(gameObject);
    }

    public override void ReceiveDamage()
    {
        healthPoints.DecreaseLife();
        // Debug.Log("LOST HEALTH. CURRENT HEALTH: " + healthPoints.currentHealth);
    }
    public void AutoFire()
    {
        if(hasFired)
        {
            return;
        }
        Attack();
        StartCoroutine(FireCooldownTimer(currentFireRate));
    }
    IEnumerator FireCooldownTimer(float fireRate)
    {
        hasFired = true;
        yield return new WaitForSeconds(fireRate);
        hasFired = false;
    }

    public void OnFireRatePickup(float duration, float newFireRate)
    {
        if(BuffDuration != null)
        {
            StopCoroutine(BuffDuration);
        }
        BuffDuration = BuffTimer(duration);
        currentFireRate = newFireRate;
        StartCoroutine(BuffDuration);
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
            Debug.Log("I PICKED UP NUKE!");
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
            Debug.Log("I USE NUKE!");
            GameManager.singleton.OnNuke();
            hasNuke= false;
        }
    }
    private IEnumerator BuffTimer(float duration)
    {
        while(duration>0)
        {
            duration -= Time.deltaTime;
            // this is where you want to maybe add a UI element
            yield return null;
        }
        currentFireRate = OriginalFireRate;
    }

}
