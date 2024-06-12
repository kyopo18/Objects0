
using System;
using System.Data.Common;
using UnityEngine;
using UnityEngine.Events;
[CreateAssetMenu(fileName = "New Weapon", menuName = "Create Weapon (Melee)")]
public class MeleeSpikeWeapon : Weapon
{
    private Spike[] spikes;
    public void SetupMeleeWeapon(Spike[] spikes, string target, int damage)
    {
        foreach (Spike spike in spikes)
        {
            spike.SetupSpike(target, damage);
        }
        this.spikes = spikes;
    }
    public void AttackModeOn()
    {

        foreach (Spike spike in spikes) 
        {
            spike.AttackMode();
        }
    }
    public void AttackModeOff()
    {
        foreach(Spike spike in spikes)
        {
            spike.PassiveMode();
        }
    }
}
