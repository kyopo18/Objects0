//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Player0 :Character0
//{
//    // Frank is a Weiner class soldier from the HotDog Kingdom.
//    // Sizes vary: Weakling, Weeny, Weiner, Smoky, Sausage, Summer Sausage, Legendary. Mythical.

//    // Frank's Default Attributes:
//    public HealthManager0 healthPoints; // Frank's Default Health Bar.

 

//    [SerializeField] private float speed; // Frank's Default Walking Speed.
//    //[SerializeField] private float runningSpeed; // Frank's Default Running Speed.
//    //[SerializeField] private float crouchMoveSpeed; // Frank's Default Crouching Move Speed.
//    [SerializeField] private int fireRate; // Frank's Default Rate Of Fire based on his Training and Experience.
//    //[SerializeField] private float morale; // Frank's starting Default Level of Morale.
//    //[SerializeField] private int size; // Frank's current Size. (Determines Frank's permanent increase in starting health and morale from a Minimum to a Maximum Size.)
//    //[SerializeField] private int strength; // Frank's current strength. (Strength determines ability to wield weapons.)

//    // Frank's Attacking Based Set Manoeveurs.

//    // Frank's Physical Melee attacks.
//    //public override void MeleeAttack()
//    //{
//    //    Debug.Log("Frank is Melee Attacking with any Melee Weapon. Includes tooth pick.");
//    //}

//    //public override void SlicingAttack()
//    //{
//    //    Debug.Log("Frank is Slicing with a KnifeLike Slicing Weapon.");
//    //}

//    // Frank's Ranged Attacks.
//    public override void RangedAttack()
//    {
//        Debug.Log("Frank is Ranged Attacking with a Ranged Weapon. Usually shooting.");
//    }

//    public void Throwing() // Requires a Throwable object.
//    {
//        Debug.Log("Frank is Throwing an Explosive Potato and/or Throwable object such as toothpick of any type.");
//    }

//    // Frank's Ranged abilities and attacks that require tools to utilize.
//    public void Spitting() // Requires a Straw of Any Type
//    {
//        Debug.Log("Frank is Spitting using a Straw of any Type.");
//    }

//    public void Scooping() // Requires a Spoon or Fork of Any Type
//    {
//        Debug.Log("Frank is Scooping with any type of Spoon and/or Fork");
//    }

//    public void Flinging() // Requires a Spoon or Fork of Any Type with enough durability can Fling ally short distance.
//    {
//        Debug.Log("Franks is Flinging an obstacle towards an area using any Type of Spoon and/or Fork after Scooping.");
//    }

//    // Frank's Mobilization
//    public override void Move() // Regular speed movement.
//    {
//        Debug.Log("Frank is Moving and walking to an area.");
//    }

//    public void Running() // A running action burst of speed.
//    {
//        Debug.Log("Frank is Running to an area.");
//    }

//    public void Jumping()
//    {
//        Debug.Log("Frank is Jumping");
//    }

//    public void Crouching() // Crouching to avoid enemy fire. Can crouch move to a better position.
//    {
//        Debug.Log("Frank is crouching.");
//    }

//    public void Ducking() // Ducking to avoid enemy fire. Can not move while ducking used while in a GMOR or hiding behind obstacles.
//    {
//        Debug.Log("Frank is Ducking");
//    }

//    // Other actions Frank can do..

//    public void Sprinkling() // sprinkle the item preservatives of any kind to give buffs.
//    {

//    }
//    public void PickUp()
//    {
//        Debug.Log("Frank is Picking Up an Item for the RuckSack and/or Picking Up an Obstacle to Move and Drop.");
//    }

//    public void Drop()
//    {
//        Debug.Log("Frank is Dropping an Item or Obstacle to place on the Battlefield.");
//    }

//    public void Dig() // must use a spoon.
//    {
//        Debug.Log("Frank is Digging with a Type of Spoon.");
//    }

//    // Drive Thru Actions: The DriveThru is a headquarters for calling in Fries or Volley of Fries.
//    public void DriveThru()
//    {
//        Debug.Log("I'd like to place an order!");
//    }

//    // End game Actions.

//    public override void DeadMeat()
//    {
//        Debug.Log("Frank is Dead Meat. Player is Dead.");
//    }

//    public void ThrowingAnotherWeinerOntheGrill()
//    {
//        Debug.Log("Frank is respawning at the last save point or spawn point in a multiplayer game.");
//    }

  

//    public Player0(float speed) // add more parameters to Frank if needed.
//    {
//        // EVERYTHING HAPPENS HERE WHEN A "FRANK" IS SPAWNED.

//        this.speed = speed; //.this is used for the specific object that is named in the current constructor.
//        healthPoints = new HealthManager0(100); // this value is for the Player's character its fixed based on seasoning level.


//    }
//}
