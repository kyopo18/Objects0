using UnityEngine;
using UnityEngine.Rendering;

public class RayGun : Enemy
{
    private LineRenderer beam;

    private Camera cam;

    private Vector3 origin;
    private Vector3 endPoint;
    private Vector3 playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        // Grabbed our laser.
        beam = this.gameObject.AddComponent<LineRenderer>();
        beam.startWidth = 0.2f;
        beam.endWidth = 0.2f;

        //Grab main camera
        cam = Camera.main;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            checkLaser();
        }
        //else beam.enabled = false;
    }

    void checkLaser()
    {
        //Finding the origin and end point of laser.
        

        origin = this.transform.position +
            this.transform.forward * 0.5f * this.transform.lossyScale.z;
        endPoint = origin + this.transform.forward * 9f;

        //endPoint = origin + this.transform.forward * 9f;
        playerPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        
        endPoint = playerPosition;



        //Set end point of laser.
        beam.SetPosition(0, origin);
        beam.SetPosition(1, endPoint);
        beam.enabled = true;
        //Draw the laser
    }
}
