
using System.Dynamic;
using UnityEngine;


//Enemies and Players will derive from this class
public abstract class Character : MonoBehaviour, IDamageable
{
    [SerializeField] private float speed;
    protected Health healthPoints;
    [SerializeField] protected Weapon weapon;
    [SerializeField] protected int maxHealth;
    [SerializeField] protected Rigidbody2D rigidBody;

    protected virtual void Start()
    {
        healthPoints = new Health(maxHealth);
        weapon = ScriptableObject.CreateInstance<Weapon>();
    }
protected abstract void Attack(); // a virtual method means that it can be overridden

    public abstract void Die();

    public virtual void SetWeapon(Weapon newWeapon)
    {

    }
    public virtual void Move(Vector2 direction, float angle)
    {
        rigidBody.AddForce(direction.normalized * speed * 
        Time.deltaTime); // *500f for a hard a value and use a lower speed.
        transform.rotation = Quaternion.Euler(0, 0, angle); // rotation
    }

    public virtual void ReceiveDamage()
    {
        healthPoints.DecreaseLife();
    }

    public virtual void ReceiveDamage(int damage)
    {
        healthPoints.DecreaseLife(damage);
    }
}
