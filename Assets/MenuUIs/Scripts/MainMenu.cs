using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MainMenu : MonoBehaviour
{
    public AudioSource PlayGameSound;
    public AudioClip LaserSound;
    public void PlayGame()
    {
        Time.timeScale = 1f;
        //PlayGameSound.PlayOneShot(LaserSound);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game has Quit");
    }

    
}
