
using UnityEngine;

public class Enemy : Character
{
    [SerializeField] public float attackDistance;
    protected Player target;
    [SerializeField] private float enemyCoolDown = 3f;
    protected float enemyTimer;
    
    protected override void Start()
    {
        base.Start();
        SetUpEnemy();
    }

    public void SetUpEnemy()
    {
        target = FindObjectOfType<Player>();
    }

    public void SetUpEnemy(int healthParam)
    {
        healthPoints = new Health(healthParam);
        target = FindObjectOfType<Player>();
        healthPoints.OnHealthChanged.AddListener(ChangedHealth);
    }
    public override void Attack() //Default Attck
    {
        target.ReceiveDamage();
    }

    private void FixedUpdate()
    {
        if (target == null)
        {
            return;
        }
        else
        {
            Move();
        }
    }
    public Enemy()
    {

    }
    public override void Die()
    {
        GameManager.singleton.scoreManager.IncreaseScore();
        Destroy(gameObject);
    }

    protected virtual void Move()
    {
        Vector2 direction = target.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // if distance from target is less than attackDistance
        if (Vector2.Distance(target.transform.position, transform.position) > attackDistance)
        {
            base.Move(direction, angle);
        }
        else //everytime the enemy is close to the player
        {
            rigidBody.velocity = Vector2.zero; 
            if (enemyTimer <= 0)
            {
                enemyTimer = enemyCoolDown;
                Attack();
            }
            else // Decreases timer to 0 in real time.
            {
                enemyTimer -= Time.deltaTime;
            }

            
        }

    }

}
