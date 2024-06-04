using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    [SerializeField] List<AudioClip> ShootSound;
    [SerializeField] List<AudioClip> HitSound;
    [SerializeField] List<AudioClip> PickupSound;
    
    AudioSource audioSource;

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
        audioSource = GetComponent<AudioSource>();
        
    }

   
    public void PlayShootSound(Vector3 pos, int index = 0)
    {
        PlaySound(ShootSound[index], pos);
    }
    public void PlayHitSound(Vector3 pos, int index = 0)
    {
        PlaySound(HitSound[index], pos);
    }
    public void PlayPickupSound(Vector3 pos, int index = 0)
    {
        PlaySound(PickupSound[index], pos);
    }
   

    private void PlaySound(AudioClip sound, Vector3 pos)
    {
        
        AudioSource.PlayClipAtPoint(sound, pos);
    }

}
