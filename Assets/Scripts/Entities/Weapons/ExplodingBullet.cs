
using UnityEngine;

public class ExplodingBullet : Bullet
{
    [SerializeField] private ParticleSystem particles;
    public override void OnTriggerEnter2D(Collider2D collision)
    {
        
        particles.Play();
        base.OnTriggerEnter2D(collision);

    }
}

