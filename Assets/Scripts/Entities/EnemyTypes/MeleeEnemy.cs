using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : Enemy
{
    private Animator animator;
    private MeleeSpikeWeapon spike;
    [SerializeField] private Spike[] spikes;

    public MeleeEnemy()
    {
    }
   protected override void Start()
    {
        base.Start();
        spike = Instantiate(weapon as MeleeSpikeWeapon, transform);
        spike.SetSpikes(spikes);
        SetWeapon(spike);
        spike.SetTarget(target.tag);
        animator = GetComponent<Animator>();
    }

    public override void Attack()
    { 
        spike.AttackModeOn(animator, true);
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
        while (Vector2.Distance(target.transform.position, transform.position) <= Time.deltaTime * attackDistance * 235f)
        {
            Attack();
        }
    }
}
