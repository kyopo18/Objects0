
using UnityEngine;

public class Enemy : Character
{
    
    [SerializeField] public float damageTimer;
    [SerializeField] public float enemyShootTimer = 2f;
    [SerializeField] public float attackDistance;
    protected Player target;
    
    protected override void Start()
    {
        base.Start();
        target = FindObjectOfType<Player>();
        healthPoints.OnHealthChanged.AddListener(ChangedHealth);
    }

    public void SetUpEnemy(int healthParam)
    {
        healthPoints = new Health(healthParam);
        target = FindObjectOfType<Player>();
        healthPoints.OnHealthChanged.AddListener(ChangedHealth);
    }
    public override void Attack() 
    { 
    }
        public void ChangedHealth(int health)
    {
        Debug.Log("LIFE HAS CHANGED TO " + health);
        if (health <= 0)
        {
            Die();
        }
    }
    private void FixedUpdate()
    {
        if (target == null)
        {
            return;
        }

        Vector2 direction = target.transform.position - transform.position;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Move(direction, angle);

    }
    public Enemy()
    {

    }
    public override void Die()
    {
        GameManager.singleton.scoreManager.IncreaseScore();
        Destroy(gameObject);
    }

    public override void Move(Vector2 direction, float angle)
    {
        // if distance from target is less than attackDistance
        if (Vector2.Distance(target.transform.position, transform.position) > attackDistance)
        {
            base.Move(direction, angle);
        }
        else //everytime the enemy is close to the player
        {
            // STOP IMMEDIATELY
            rigidBody.velocity = Vector2.zero; //ADD A TIMER HERE

            damageTimer += Time.deltaTime; 
            if(damageTimer >= 0.65f) 
            {
                target.ReceiveDamage();
                damageTimer = 0f;
            }
   
        }

    }

}
