using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : Enemy
{
    [SerializeField] private int damage;
    MeleeSpikeWeapon melee;
    [SerializeField] private Spike[] spikes;

    public MeleeEnemy()
    {
    }
    protected override void Start()
    {
        base.Start();
        melee = weapon as MeleeSpikeWeapon;
        melee.SetupMeleeWeapon(spikes, target.tag, damage);
    }

    public override void Attack()
    {
        if (Vector2.Distance(target.transform.position, transform.position) <= Time.deltaTime * attackDistance * 235f)
        {
            melee.AttackModeOn();
        }
        else melee.AttackModeOff();
    }
    protected override void Move()
    {
        Vector2 direction = target.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // if distance from target is less than attackDistance
        if (Vector2.Distance(target.transform.position, transform.position) > attackDistance)
        {
            base.Move(direction, angle);
        }
        else
        {
            rigidBody.velocity = Vector2.zero;
        }
        Attack();
    }
}
