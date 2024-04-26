//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class MachineGunEnemy1 : Enemy1
//{
//    [SerializeField] private float damageTimer1;
//    [SerializeField] private float attackDistance1;
//    private Player1 target1;

   

//    // Start is called before the first frame update
//    void Start()
//    {
//        target = FindObjectOfType<Player1>();
//    }

   
//    void FixedUpdate()
//    {
//        Vector2 direction = target1.transform.position - transform.position;
//        Move(direction, 0);
//    }

//    public MachineGunEnemy1(string enemyName1) : base(enemyName1)
//    {

//    }

//    public override void Move(Vector2 direction, float angle)
//    {
//        // if distance from target is less than attackDistance
//        if (Vector2.Distance(target.transform.position, transform.position) > attackDistance)
//        {
//            base.Move(direction, angle);
//        }
//        else //everytime the enemy is close to the player
//        {
//            // STOP IMMEDIATELY
//            rigidBody.velocity = Vector2.zero; //ADD A TIMER HERE

//            damageTimer += Time.deltaTime;
//            if (damageTimer >= 0.65f)
//            {
//                target.ReceiveDamage();
//                damageTimer = 0f;
//            }




//        }

//    }
//}
