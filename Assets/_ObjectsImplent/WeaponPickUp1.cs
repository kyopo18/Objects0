using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp1 : PickUp1
{
    [SerializeField] private Weapon1 newWeapon;
    protected override void PickMe(Character1 characterToChange)
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
