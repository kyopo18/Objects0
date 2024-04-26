using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow1 : MonoBehaviour
{
    [SerializeField] Player1 myPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (myPlayer == null) 
        {
            return;
        }
        //Camera follows player
        // add an interpolation and delay to follow player. Vector3.lerp use a lerp
        transform.position = myPlayer.transform.position + new Vector3(0, 0, -10);
        
    }
}
