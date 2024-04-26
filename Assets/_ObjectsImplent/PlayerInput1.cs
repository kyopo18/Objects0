using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput1 : MonoBehaviour
{
    public Camera mainCamera;
    private Player1 myPlayer1;
    public Vector2 direction;
    public float angleToRotate;



    // Start is called before the first frame update
    void Start()
    {
        
        myPlayer1 = GetComponent<Player1>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            myPlayer1.Attack();
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
        myPlayer1.Move(new Vector2(horizontalInput, verticalInput), angleToRotate);

       
    }
}
