//using System.Collections;
//using System.Collections.Generic;
//using System.Text;
//using UnityEngine;

//public class LevelLoader : MonoBehaviour
//{
//    [SerializeField] private float speedToCreateThePlayer;

//    public static int difficulty;
//    public Player player1;
//    public Enemy normalEnemy;
//    public ExplodingEnemy explodingEnemy;

//    // Start is called before the first frame update
//    void Start()
//    {
//        // Primitive Data Types
//        // int = -1000000 < 100000
//        // float = 100000.5f < 100000.f
//        // bool = true or false
//        // string = "text here"
//        //char[]
//        // char = ''
//        // double = float but 10000000000.0 and 1000000000.0
//        // long = int but longer 10000000 and 10000000 byte range
        
//        Player player = new Player(10f);
//        //player.speed = 5; don't need hard code value if parameter used
//        Player p2 = new Player(5);

//        //p2.speed = 10; // ""
//        //Enemy enemy = new Enemy();  
//        ////Weapon weapon = new Weapon(); 
//        //player.health = new Health();
//        //player.weapon = new Weapon();

//        //player1 new Player(speedToCreateThePlayer);
//        //normalEnemy = new Enemy();
//        //explodingEnemy = new ExplodingEnemy();



//        //player.health.TakeDamage();
//        //player.Move();
//        //player.speed = 10f;
//        //Player player2 = new Player();
//        //player2.speed = 50f;
//        //player2.Move(); //Instances of player1 and player2 in the LevelLoader

        

//        normalEnemy = gameObject.AddComponent<Enemy>();
//        explodingEnemy = new ExplodingEnemy("Crash");

//        normalEnemy = new ExplodingEnemy("Crash");
//        Debug.Log(normalEnemy.enemyName);
//        Debug.Log(explodingEnemy.enemyName);
//        explodingEnemy.Attack();
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//}


