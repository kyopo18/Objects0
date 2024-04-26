using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    private float speed;
    private int strength;
    private Health healthPoints;
    private string thing;

    // Start is called before the first frame update
    public abstract void Attack();


    // Update is called once per frame
    public virtual void Die()
    {
        Debug.Log("dying");
    }


    public abstract void Move();
   
    public Character()
    {

    }
    

    public Character(float speed, int health)
    {
        this.speed = speed;
        healthPoints = new Health(health);
    }

    public Character(string thing)
    {
        this.thing = thing;
    }
}
