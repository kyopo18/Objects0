using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodingEnemy0 : Enemy0
{
    // The Hamburger that is devoted enough to strap an explosive to itself to kill HotDogs.
    // Might be changed to a called in drone from Hamburger DriveThru for political reasons.
    // Based off of kamikaze warriors of Japan in World War II specifically.


    public float rangeOfExplosion;
    public override void MeleeAttack()
    {
        Debug.Log("ExplodingEnemy0 is Melee Attacking by grabbing and detonating.");
        DeadMeat();
    }
    public override void RangedAttack()
    {
        // Does nothing on purpose.
        Debug.Log("Not an enemy with ranged capabilities other than toothpicks and spit balls in hard mode.");

    }
    public ExplodingEnemy0()
    {

    }
}
