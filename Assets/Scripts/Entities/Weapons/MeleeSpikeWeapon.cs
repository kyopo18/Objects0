
using System;
using System.Data.Common;
using UnityEngine;
using UnityEngine.Events;

public class MeleeSpikeWeapon : Weapon
{
    private Spike[] spikes;
   
    public void AttackModeOn(Animator animator, bool on)
    {
        if (on == true)
        {
            animator.SetBool("isAttacking", true);
        }
        else animator.SetBool("isAttacking", false);
    }
    public void SetTarget(string target)
    {
        foreach (var spike in spikes)
        {
            spike.SetUpBullet(target, damage);
        }
    }
    public void SetSpikes(Spike[] spikes)
    {
        this.spikes = spikes;
    }
}
