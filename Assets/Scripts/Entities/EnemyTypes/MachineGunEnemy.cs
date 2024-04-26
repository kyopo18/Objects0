//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class MachineGunEnemy : Enemy
//{
//    [SerializeField] private float damageTimer;
//    [SerializeField] private float attackDistance;
//    private Player target;

   

//    // Start is called before the first frame update
//    void Start()
//    {
//        target = FindObjectOfType<Player>();
//    }

   
//    void FixedUpdate()
//    {
//        Vector2 direction = target.transform.position - transform.position;
//        Move(direction, 0);
//    }

//    public MachineGunEnemy(string enemyName) : base(enemyName)
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
