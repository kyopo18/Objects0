using System.Collections;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager singleton;

    public ScoreManager1 scoreManager;

    Coroutine coroutine;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private Enemy[] enemyPrefabs;

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
        }



    }

}
