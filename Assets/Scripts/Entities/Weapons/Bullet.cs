
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    protected string targetTag;
    protected int damage;

    private void Start()
    {
        Destroy(gameObject, 3f);
    }

    public void SetUpBullet(string tag, int damageParam)
    {
        damage = damageParam;
        targetTag = tag;
    }

    private void Update()
    {
        //JUST MOVING FORWARD
        transform.Translate(Vector2.right * bulletSpeed * Time.deltaTime);
    }

    public virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag(targetTag))
        {
            //DO Damage to enemy
            collision.GetComponent<IDamageable>().ReceiveDamage(damage);
            Destroy(gameObject);
            // Debug.Log("Its hitting!");
        }
    }
}
