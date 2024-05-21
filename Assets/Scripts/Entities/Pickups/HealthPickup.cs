using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : PickUp
{
    [SerializeField] int heal = 10;
    protected override void PickMe(Player player)
    {
        player.OnHealthPickup(heal);
        base.PickMe(player);
    }
}
