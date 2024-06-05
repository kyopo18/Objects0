using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Player myPlayer;
    public Vector2 direction;
    public float angleToRotate;
    void Start()
    {
        myPlayer = GetComponent<Player>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            myPlayer.AutoFire();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Keyboard Inputs
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        //mouse positions
        
        direction = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
        
        angleToRotate = Mathf.Atan2(direction.y - transform.position.y, direction.x - transform.position.x) * Mathf.Rad2Deg;

        //sending the input as coordinates 
        myPlayer.Move(new Vector2(horizontalInput, verticalInput), angleToRotate);

       
    }
}
