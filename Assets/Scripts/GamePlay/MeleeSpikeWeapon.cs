
using System;
using System.Data.Common;
using UnityEngine;
using UnityEngine.Events;

public class MeleeSpikeWeapon : Weapon
{
    public int damage;
    private Spike[] spikes;
    private Character weaponOwner;
   
    public virtual void WeaponSetup(Character target, Character owner)
    {
        weaponOwner = owner;
        
        spikes = weaponOwner.GetComponentsInChildren<Spike>();
        for (int i = 0; i < spikes.Length; i++)
        {
            spikes[i].damage = damage;
            spikes[i].target = target;
            
        }
    }

    public void AttackModeOn(Animator animator, bool on)
    {
        if (on == true)
        {
            animator.SetBool("isAttacking", true);
        }
        else animator.SetBool("isAttacking", false);

    }
}
