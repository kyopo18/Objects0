using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireratePickup : PickUp
{
    [SerializeField] float duration;
    [SerializeField] float fireRate;
    protected override void PickMe(Player player)
    {
        player.OnFireRatePickup(duration, fireRate);
        base.PickMe(player);
    }
}
