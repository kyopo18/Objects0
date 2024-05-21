using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NukePickup : PickUp
{
    protected override void PickMe(Player player)
    {
        player.OnNukePickup();
        base.PickMe(player);
    }
}
