using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : PickUp
{
    [SerializeField] private Weapon newWeapon;
    protected override void PickMe(Character characterToChange)
    {
        //call method inside character that changes weapon
        //OR
        //CALL METHOD INSIDE PLAYER
        //OR CALL METHOD INSIDE ENEMY TOO OR ALL CHARACTERS
        //SEND "newWeapon" to the player
        characterToChange.SetWeapon(newWeapon);
        base.PickMe(characterToChange);
    }
}
