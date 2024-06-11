
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Create Weapon")]
public class Weapon : ScriptableObject
{
    [SerializeField] private string weaponName;
    [SerializeField] private Sprite icon;
    [SerializeField] internal int damage;
    
    //Player1 player1;
    [SerializeField] protected Bullet bulletReference;
    // [SerializeField] private bool exploding = false;

    //every 2seconds spawn bullet while OnClick use coroutine or timer
    //the other 2 enemies
    //firerate hold mouse button down to fire more faster rate and hold click shoot out stop click stop shoot.
    public virtual void WeaponSetup(Bullet bulletReference)
    {
        this.bulletReference = bulletReference;
    }
    public Weapon()
    {

    }
}
