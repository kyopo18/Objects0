using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnPickupManager : MonoBehaviour
{
    public static SpawnPickupManager instance;
    [SerializeField] PickUp[] spawnablePickups;
    [SerializeField, Range(0,1)] float chanceOfSpawn = 1f;

    private void Awake()
    {
        //Singleton
        if (instance == null)
        {
            instance = this;
            transform.parent = null;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void SpawnPickup(Vector3 positionToSpawn)
    {
        if(Random.value <= chanceOfSpawn){
            PickUp selectedPickup = spawnablePickups[Random.Range(0,spawnablePickups.Length)];
            Instantiate(selectedPickup, positionToSpawn, Quaternion.identity);
        }
    }
}
