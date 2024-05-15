using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : Enemy
{
    [SerializeField] public MeleeSpikeWeapon meleeWeaponPrefab;
    internal MeleeSpikeWeapon spikeWeapon;
    Animator animator;
    public MeleeEnemy()
    {
    }
   protected override void Start()
    {
        healthPoints = new Health(maxHealth);
       spikeWeapon = Instantiate(meleeWeaponPrefab);
        spikeWeapon.WeaponSetup(target, this);
        healthPoints.OnHealthChanged.AddListener(ChangedHealth);
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    public override void Attack()
    {
        Debug.LogWarning("Attacking w/ melee");
    }
   
    void FixedUpdate()
    {
        base.Move();
        if (Vector2.Distance(target.transform.position, transform.position) <= Time.deltaTime * attackDistance * 235f)
        {
         spikeWeapon.AttackModeOn(animator, true);
        }
        else
        {
            spikeWeapon.AttackModeOn(animator, false);
        }
    }
}
