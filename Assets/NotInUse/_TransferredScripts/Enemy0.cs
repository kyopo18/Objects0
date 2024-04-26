using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy0
{
    // Smasher is a Burger class soldier from the HamBurger Kingdom.
    // Sizes vary: Slider, PunyPatty, Burger, QuarterPounder, WholePounder, Challenger, Legendary. Mythical.

    // Smasher's Default Attributes:
    public HealthManager0 healthPoints; // Smasher's Default Health Bar.
    [SerializeField] private float speed; // Smasher's Default Walking Speed.
    
    [SerializeField] private int fireRate; // Smasher's Default Rate Of Fire based on his Training and Experience.
    

    // Smasher's Attacking Based Set Manoeveurs.

    // Smasher's Physical Melee attacks.
    public virtual void MeleeAttack()
    {
        Debug.Log("Smasher is Melee Attacking with any Melee Weapon. Includes tooth pick.");
    }

    public virtual void SlicingAttack()
    {
        Debug.Log("Smasher is Slicing with a KnifeLike Slicing Weapon.");
    }

    // Smasher's Ranged Attacks.
    public virtual void RangedAttack()
    {

        Debug.Log("Smasher is Ranged Attacking with a Ranged Weapon. Usually shooting.");
    }

    public void Throwing() // Requires a Throwable object.
    {
        Debug.Log("Smasher is Throwing an Explosive Potato and/or Throwable object such as toothpick of any type.");
    }

    // Smasher's Ranged abilities and attacks that require tools to utilize.
    public void Spitting() // Requires a Straw of Any Type
    {
        Debug.Log("Smasher is Spitting using a Straw of any Type.");
    }

    public void Scooping() // Requires a Spoon or Fork of Any Type
    {
        Debug.Log("Smasher is Scooping with any type of Spoon and/or Fork");
    }

    public void Flinging() // Requires a Spoon or Fork of Any Type with enough durability can Fling ally short distance.
    {
        Debug.Log("Smasher is Flinging an obstacle towards an area using any Type of Spoon and/or Fork after Scooping.");
    }

    // Smasher's Mobilization
    public void Move() // Regular speed movement.
    {
        Debug.Log("Smasher is Moving and walking to an area.");
    }

    public void Running() // A running action burst of speed.
    {
        Debug.Log("Smasher is Running to an area.");
    }

    public void Jumping()
    {
        Debug.Log("Smasher is Jumping");
    }

    public void Crouching() // Crouching to avoid enemy fire. Can crouch move to a better position.
    {
        Debug.Log("Smasher is crouching.");
    }

    public void Ducking() // Ducking to avoid enemy fire. Can not move while ducking used while in a GMOR or hiding behind obstacles.
    {
        Debug.Log("Smasher is Ducking");
    }

    // Other actions Smasher can do..
    public void Sprinkling() // sprinkle the item preservatives of any kind to give buffs.
    {

    }
    public void PickUp()
    {
        Debug.Log("Smasher is Picking Up an Item for the RuckSack and/or Picking Up an Obstacle to Move and Drop.");
    }

    public void Drop()
    {
        Debug.Log("Smasher is Dropping an Item or Obstacle to place on the Battlefield.");
    }

    public void Dig() // must use a spoon.
    {
        Debug.Log("Smasher is Digging with a Type of Spoon.");
    }

    // Drive Thru Actions: The DriveThru is a headquarters for calling in Fries or Volley of Fries.
    public void DriveThru()
    {
        Debug.Log("I'd like to place an order!");
    }

    // End game Actions.

    public void DeadMeat()
    {
        Debug.Log("Smasher is Dead Meat. Burger is Dead Meat.");
    }

    public void ThrowingAnotherPattyOntheGrill()
    {
        Debug.Log("Smasher is respawning at the last save point or spawn point in a multiplayer game.");
    }

    public Enemy0()
    {
        //empty constructor used to construct new type of enemy. Use as needed.
    }
    public Enemy0(float speed, int shelflifevalue)
    {
        this.speed = speed;
        healthPoints = new HealthManager0(shelflifevalue); // this value is for the different enemies spawning.
    }
}
