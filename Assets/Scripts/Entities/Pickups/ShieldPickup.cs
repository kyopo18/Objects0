using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPickup : PickUp
{
    [SerializeField] int shieldAmount = 0;
    protected override void PickMe(Player player)
    {
        player.OnShieldPickup(shieldAmount);
        base.PickMe(player);
    }
}
