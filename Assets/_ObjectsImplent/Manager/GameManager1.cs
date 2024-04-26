using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEditorInternal.Profiling.Memory.Experimental.FileFormat;
using UnityEngine;


public class GameManager1 : MonoBehaviour
{
    public static GameManager1 singleton;

    public ScoreManager1 scoreManager;

    Coroutine coroutine;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private Enemy1 enemyPrefab;
    [SerializeField] private RapidFireEnemy1 rapidFireEnemyPrefab;
    [SerializeField] private KamikazeEnemy1 kamikazeEnemyPrefab;
    //[SerializeField] private AccurateEnemy1 accurateEnemyPrefab;
    [SerializeField] private int enemyCount;
    [SerializeField]
    private string[] enemyTypes = { "KamikazeEnemy1", "RapidFireEnemy1", "AccurateEnemy1",
        "KamikazeEnemy1", "RapidFireEnemy1", "KamikazeEnemy1" };


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
            if (enemyTypes[i] == "RapidFireEnemy1")
            {
                RapidFireEnemy1 enemy = Instantiate(rapidFireEnemyPrefab, randomSpawnPoint.position, Quaternion.identity);
                enemy.SetUpEnemy(1);
            }
            if (enemyTypes[i] == "Kamikaze1")
            {
                KamikazeEnemy1 enemy = Instantiate(kamikazeEnemyPrefab, randomSpawnPoint.position, Quaternion.identity);// enemy = new KamikazeEnemy1();
                enemy.SetUpEnemy(1);
            }
            //if (enemyTypes[i] == "AccurateEnemy1")
            //{
            //    Enemy1 enemy = Instantiate(accurateEnemyPrefab, randomSpawnPoint.position, Quaternion.identity);//  enemy = new AccurateEnemy1();
            //    enemy.SetUpEnemy(1);
            //}
        }


    }
    IEnumerator SpawnEnemy() //Random.Range(0, spawnPoints.Length)
    {

        enemyCount = 0;
        while (true)
        {

            //if(enemyCount / 10 == )
            yield return new WaitForSeconds(5f);
            int randomIndex = Random.Range(0, spawnPoints.Length);
            Transform randomSpawnPoint = spawnPoints[randomIndex];
            //XSetUpEnemy();
            Debug.Log(randomSpawnPoint.position);
            Enemy1 enemy = Instantiate(enemyPrefab, randomSpawnPoint.position, Quaternion.identity);
            enemy.SetUpEnemy(1);
            //Enemy1 enemyx = Instantiate(rapidFireEnemyPrefab, randomSpawnPoint.position, Quaternion.identity);
            //enemyx.SetUpEnemy(1); 
            //Enemy1 enemyy = Instantiate(kamikazeEnemyPrefab, randomSpawnPoint.position, Quaternion.identity);
            //enemyy.SetUpEnemy(1);
            //Debug.Log("TEST");
        }



    }

}
