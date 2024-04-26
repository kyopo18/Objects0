
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Create Weapon")]
public class Weapon : ScriptableObject
{
    [SerializeField] private string weaponName;
    [SerializeField] private Sprite icon;
   [SerializeField] private int shootDamage;
    [SerializeField] private int shootSpeed;
    [SerializeField] private float shootAccuracy;
    [SerializeField] private float shootDistance;
   //Player1 player1;
   [SerializeField] Bullet bulletReference;
   // [SerializeField] private bool exploding = false;

    //every 2seconds spawn bullet while OnClick use coroutine or timer
    //the other 2 enemies
    //firerate hold mouse button down to fire more faster rate and hold click shoot out stop click stop shoot.
    public void ShootMe(Vector2 position, Quaternion direction, string tag)
    {
        //Player player = gameObject.CompareTag("Player");
        Bullet tempBullet = GameObject.Instantiate(bulletReference, position, direction);
        tempBullet.SetUpBullet(tag, 1);
        
    }
     //KVN H!!!!!!!!!!!!!
    public void ShootMe(Vector2 sighting) 
    {
        //Player player = gameObject.CompareTag("Player");
        Bullet tempBullet = GameObject.Instantiate(bulletReference, sighting, Quaternion.identity);

    }

    public void ShootMe(Vector2 sighting, float accshoot) // Highly accurate sighting low fire rate.
    {
        //Player player = gameObject.CompareTag("Player");
        Bullet tempBullet = GameObject.Instantiate(bulletReference, sighting, Quaternion.identity);
        

    } //KVN H!!!!!!!!!!!!!!!!!!!


    public Weapon()
    {

    }

    public Weapon(Bullet bulletPrefab)
    {
        bulletReference = bulletPrefab;
    }
}
