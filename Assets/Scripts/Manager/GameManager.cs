using System.Collections;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager singleton;

    public ScoreManager1 scoreManager;

    Coroutine coroutine;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private Enemy enemyPrefab;
    [SerializeField] private RapidFireEnemy rapidFireEnemyPrefab;
    [SerializeField] private KamikazeEnemy kamikazeEnemyPrefab;
    //[SerializeField] private AccurateEnemy accurateEnemyPrefab;
   // [SerializeField] private int enemyCount;
    [SerializeField]
    private string[] enemyTypes = { "KamikazeEnemy", "RapidFireEnemy", "AccurateEnemy",
        "KamikazeEnemy", "RapidFireEnemy", "KamikazeEnemy" };


    // Start is called before the first frame update

    private void Awake()
    {
        singleton = this;
    }
    void Start()
    {
        StartSpawningEnemy();

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void EndGame()
    {
        //StopCoroutine(SpawnEnemy());
        StopCoroutine(coroutine);
        scoreManager.RegisterHighScore();
    }
    public void StartSpawningEnemy()
    {
        coroutine = StartCoroutine(SpawnEnemy());
    }

    protected void XSetUpEnemy()
    {
        Transform randomSpawnPoint;
        for (int i = 0; i < enemyTypes.Length; i++)
        {
            randomSpawnPoint = spawnPoints[i];
            if (enemyTypes[i] == "RapidFireEnemy")
            {
                RapidFireEnemy enemy = Instantiate(rapidFireEnemyPrefab, randomSpawnPoint.position, Quaternion.identity);
                enemy.SetUpEnemy();
            }
            if (enemyTypes[i] == "Kamikaze")
            {
                KamikazeEnemy enemy = Instantiate(kamikazeEnemyPrefab, randomSpawnPoint.position, Quaternion.identity);// enemy = new KamikazeEnemy();
                enemy.SetUpEnemy();
            }
            //if (enemyTypes[i] == "AccurateEnemy")
            //{
            //    Enemy enemy = Instantiate(accurateEnemyPrefab, randomSpawnPoint.position, Quaternion.identity);//  enemy = new AccurateEnemy1();
            //    enemy.SetUpEnemy(1);
            //}
        }


    }
    IEnumerator SpawnEnemy() //Random.Range(0, spawnPoints.Length)
    {

      //  enemyCount = 0;
        while (true)
        {

            //if(enemyCount / 10 == )
            yield return new WaitForSeconds(5f);
            int randomIndex = Random.Range(0, spawnPoints.Length);
            Transform randomSpawnPoint = spawnPoints[randomIndex];
            //XSetUpEnemy();
            Debug.Log(randomSpawnPoint.position);
            Enemy enemy = Instantiate(enemyPrefab, randomSpawnPoint.position, Quaternion.identity);
            enemy.SetUpEnemy();
            //Enemy enemyx = Instantiate(rapidFireEnemyPrefab, randomSpawnPoint.position, Quaternion.identity);
            //enemyx.SetUpEnemy(1); 
            //Enemy enemyy = Instantiate(kamikazeEnemyPrefab, randomSpawnPoint.position, Quaternion.identity);
            //enemyy.SetUpEnemy(1);
            //Debug.Log("TEST");
        }



    }

}
