using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunEnemy : Enemy
{
   

  public override void Attack()
    {
        RangedWeapon gun = weapon as RangedWeapon;
        gun.ShootMe(transform, "Player");
    }
}
