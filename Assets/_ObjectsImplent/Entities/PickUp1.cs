using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp1 : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PickMe(collision.gameObject.GetComponent<Character1>());
        }
    }

    protected virtual void PickMe(Character1 characterToChange)
    {
        Destroy(gameObject);
    }
}
