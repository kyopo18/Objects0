using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    [SerializeField] int despawn;
    private void Start() {
        Destroy(gameObject, despawn);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PickMe(collision.gameObject.GetComponent<Player>());
        }
    }

    protected virtual void PickMe(Player player)
    {
        Destroy(gameObject);
    }

    
    // Base class for nuke pickups
    public virtual void ActivateNuke()
    {



    }
}

