using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedWeapon : Weapon
{
    [SerializeField] private int shootSpeed;
    [SerializeField] private float shootAccuracy;
    [SerializeField] private float shootDistance;
    public void ShootMe(Transform targeting, string tag)
    {
        //Player player = gameObject.CompareTag("Player");
        Bullet tempBullet = Instantiate(bulletReference, targeting.position, targeting.rotation);
        tempBullet.SetUpBullet(tag, 1);
    }
  
}
