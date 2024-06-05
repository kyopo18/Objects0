using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using JetBrains.Annotations;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI HighScoreText;
    private float HighScore = 0;
    [SerializeField] public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
    public GameObject Player;
    [SerializeField] public string Menu;
    public Camera Cam;
    private AudioSource CamAudio;

    private void Start()
    {
        Cam = FindAnyObjectByType<Camera>();
        CamAudio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        Pausing();
    }
    public void Pausing()
    {
        if (Player == null)
        {
            HighScoreText.text = "High Score " + HighScore;
                Pause();
        }
    }

    // Restart Function for the Restart Button
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    // Quits Game
    public void ExitGame()
    {
        Application.Quit();
    }

    // GotoMenu Button Function
    public void GoToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(Menu);
    }
}
