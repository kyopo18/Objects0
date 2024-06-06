using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    public static ParticleManager Instance;
    [SerializeField] GameObject EnemyDiePrefab; 
    [SerializeField] GameObject EnemyExplodePrefab;
    [SerializeField] GameObject PickupPrefab1, PickupPrefab2;  
    [SerializeField]  GameObject PlayerHitPrefab;
    [SerializeField]  GameObject PlayerHealPrefab;
    [SerializeField]  GameObject PlayerDiePrefab;
    private void Awake()
    {
        //Singleton
        if (Instance == null)
        {
            Instance = this;
            transform.parent = null;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
    public void SpawnPlayerDie(Vector3 position, float duration = 1f)
    {
        SpawnParticle(position, PlayerDiePrefab, duration);
    }
    public void SpawnPlayerHit(Vector3 position, float duration = 1f)
    {
        SpawnParticle(position, PlayerHitPrefab, duration);
    }
    public void SpawnEnemyExplode(Vector3 position, float duration = 1f)
    {
        SpawnParticle(position, EnemyExplodePrefab, duration);
    }
    public void SpawnPickup(Vector3 position, int version = 0, float duration = 1f)
    {
        SpawnParticle(position, version == 0? PickupPrefab1: PickupPrefab2, duration);
    }
    public void SpawnHeal(Vector3 position, float duration = 1f)
    {
        SpawnParticle(position, PlayerHealPrefab, duration);
    }
    public void SpawnEnemyDie(Vector3 position, float duration = 1f)
    {
        SpawnParticle(position, EnemyDiePrefab, duration);
    }
    private void SpawnParticle(Vector3 position, GameObject particlePrefab, float duration )
    {
        GameObject particleInstance = Instantiate(particlePrefab, position, Quaternion.identity);
        Destroy(particleInstance, duration);
    }
}
