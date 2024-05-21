using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager singleton;

    public ScoreManager1 scoreManager;

    Coroutine coroutine;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private Enemy[] enemyPrefabs;

    private List<Enemy> enemiesAlive = new List<Enemy>() ;

    private void Awake()
    {
        singleton = this;
    }
    void Start()
    {
        StartSpawningEnemy();

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
    IEnumerator SpawnEnemy() //Random.Range(0, spawnPoints.Length)
    {
        while (true)
        {
            yield return new WaitForSeconds(5f);
            int randomIndex = Random.Range(0, spawnPoints.Length);
            Transform randomSpawnPoint = spawnPoints[randomIndex];
            Debug.Log(randomSpawnPoint.position);
            Enemy enemy = Instantiate(enemyPrefabs[Random.Range(0, enemyPrefabs.Length)], randomSpawnPoint.position, Quaternion.identity);
            enemy.SetUpEnemy();
            enemiesAlive.Add(enemy);
        }
    }
    public void OnEnemyKilled(Enemy killed)
    {
        scoreManager.IncreaseScore();
        enemiesAlive.Remove(killed);
    }
    public void OnNuke()
    {
        List<Enemy> clone = new List<Enemy>();
        clone.AddRange(enemiesAlive);
        foreach(Enemy enemy in clone)
        {
            if(enemy!=null)
            {
                enemy.Die();
            }
        }
    }

}
