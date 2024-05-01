using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunEnemy : Enemy
{
   

  public override void Attack()
    {
        weapon.ShootMe(transform, "Player");
    }
}
