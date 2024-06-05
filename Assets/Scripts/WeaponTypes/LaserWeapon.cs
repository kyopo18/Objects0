using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;
using UnityEngine.UIElements;


public class LaserWeapon : MonoBehaviour
{
    public bool inRange = false;
    public float shootRate;
    private float m_laserShootRateTimeStamp;

    //public GameObject laserShotPrefab; //05/09
    public GameObject laserBeam;

    LineRenderer lineRenderer;

    private void Update()
    {
        //if (//LaserEnemy is in firing range of "Player" tag)
        {

            if (Time.time > m_laserShootRateTimeStamp)
            {
                ShootLaser();
                m_laserShootRateTimeStamp = Time.time + shootRate;

            }

        }
    }

    public void ShootLaser() //05/11/2024
    {


        LineRenderer lineRenderer = new LineRenderer();
        lineRenderer.transform.position = transform.position;
        Instantiate(lineRenderer.gameObject);
        Debug.Log("LineisLining");
       
    }
}
