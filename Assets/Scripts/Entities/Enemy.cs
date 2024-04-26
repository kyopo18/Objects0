
using UnityEngine;

public class Enemy : Character
{
    
    [SerializeField] public float damageTimer;
    [SerializeField] public float enemyShootTimer = 2f;
    [SerializeField] public float attackDistance;
    [SerializeField] protected Bullet bulletPrefab;
    

    protected Weapon enemyWeapon;
    protected Weapon explodingWeapon;
    protected Player target;
    


    protected override void Start()
    {
        base.Start();
        target = FindObjectOfType<Player>();
        healthPoints.OnHealthChanged.AddListener(ChangedHealth);
        enemyWeapon = new Weapon(bulletPrefab); // Activity Diagram : set weapon
    }

    public void SetUpEnemy(int healthParam)
    {
        healthPoints = new Health(healthParam);
        target = FindObjectOfType<Player>();
        healthPoints.OnHealthChanged.AddListener(ChangedHealth);
    }


    //ExplodingEnemy1 Kevinmod Activity Diagram :Draw diagrams
        //public void SetUpEnemy(int healthParam, bool exploding)
        //{

        //    healthPoints = new Health1(healthParam);
        //    target = FindObjectOfType<Player1>();
        //    healthPoints.OnHealthChanged.AddListener(ChangedHealth);
        //}

        public void ChangedHealth(int health)
    {
        Debug.Log("LIFE HAS CHANGED TO " + health);
        if (health <= 0)
        {
            //increase score
            GameManager.singleton.scoreManager.IncreaseScore();
            Destroy(gameObject); //DIEs
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
    public Enemy(string enemyName1)
    {

    }

    public override void Attack() ///change this to finish assignment
    {
        target.ReceiveDamage();
        enemyWeapon.ShootMe(transform.position, transform.rotation, "Player");
        //enemyWeapon.Invoke(enemyShootTimer);
    }
    //kvn
    ////public override void Attack(int weaponType) ///change this to finish assignment
    //{
    //    // weaponType == 1 // Exploding
    //    // weaponType == 2 // MachineGun
    //    // weaponType == 0 // bau

    //    target.ReceiveDamage();
    //    enemyWeapon.ShootMe(transform.position, transform.rotation, "Player");
    //    if (weaponType == 0)
    //    {
    //        //enemyWeapon.Invoke(enemyShootTimer);
    //    }
    //    if (weaponType == 2)
    //    {
    //        // enemyWeapon.Invoke(1f);
    //    }
    //}
    //kevin
    public override void Die()
    {
    //   FindObjectOfType<Character1>Die();
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
