using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserEnemy : Enemy
{
    //05172024

    [SerializeField] LineRenderer lineRenderer;
    public override void Attack()
    {
        weapon.ShootMe(transform, "Player");
    }


    protected override void Move()
    {
        Vector2 direction = target.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // if distance from target is less than attackDistance
        if (Vector2.Distance(target.transform.position, transform.position) > attackDistance)
        {
            lineRenderer.positionCount = 0;
            base.Move(direction, angle);
        }
        else //everytime the enemy is close to the player
        {
            rigidBody.velocity = Vector2.zero;
            if (enemyTimer <= 0)
            {
                enemyTimer = enemyCoolDown;
                Attack();
            }
            else // Decreases timer to 0 in real time.
            {
                enemyTimer -= Time.deltaTime;
            }

            lineRenderer.positionCount = 2;
            lineRenderer.SetPosition(0, transform.position); // position of itself(enemy) 05172024
            lineRenderer.SetPosition(1, target.transform.position); //position of player 05172024

        }


    }

    protected override void StopTargeting()
    {
        lineRenderer.positionCount = 0;
    }


}




