using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ButtonAudioManager : MonoBehaviour
{
    public AudioSource buttonFx;
    public AudioClip hoverFx;
    public AudioClip clickFx;
    public static ButtonAudioManager singleton;


    private void Start()
    {
        if (singleton == null)
        {
            singleton = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void HoverSound()
    {
        
        buttonFx.PlayOneShot (hoverFx);
    }
    public void ClickSound()
    {
        buttonFx.PlayOneShot(clickFx);
    }
}
