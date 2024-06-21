using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] Vector3 offset;

    private void Update()
    {
        if (player != null) 
        {
                transform.position = player.transform.position + offset;
            

        }
    }

}
