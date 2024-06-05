using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DividingEnemy : Enemy
{
    [SerializeField] int numberToSpawn, iterations;
    private void Awake() {
        gameObject.SetActive(true);
    }
    public override void Die() {
        if(iterations > 0){
            StartCoroutine(StartSpawningEnemies());
            Destroy(gameObject);
            GameManager.singleton.scoreManager.IncreaseScore();
            return;
        }
        base.Die();
    }
    private void DecreaseIterations(int iterations){
        this.iterations = iterations-1;
    }
    private IEnumerator StartSpawningEnemies(){
       for (int i = 0; i<numberToSpawn; i++){
                DividingEnemy splitEnemy = Instantiate(this, transform.position + new Vector3(Mathf.Cos(2*Mathf.PI/numberToSpawn*i), Mathf.Sin(2*Mathf.PI/numberToSpawn*i)), Quaternion.identity);
                splitEnemy.DecreaseIterations(iterations);
                
            }
        yield return null;
    }
}
