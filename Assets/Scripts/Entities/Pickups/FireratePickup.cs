using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireratePickup : PickUp
{
    [SerializeField] float duration;
    protected override void PickMe(Player player)
    {
        player.OnFireRatePickup(duration);
        base.PickMe(player);
    }
}
