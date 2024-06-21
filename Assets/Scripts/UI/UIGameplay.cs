using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
public class UIGameplay : MonoBehaviour
{
    //Reference to the text showing the HEALTH
    [SerializeField] private TextMeshProUGUI healthText;
    //Reference to the text showing the SCORE
    [SerializeField] private TextMeshProUGUI scoreText;
    //Reference to the text showing the HIGH SCORE
    [SerializeField] private TextMeshProUGUI highScoreText;
    //reference to this screen "game over"
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private Player player;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.singleton.scoreManager.OnHighestScoreChanged.AddListener(UpdateHighScoreText);
        GameManager.singleton.scoreManager.OnTotalScoreChanged.AddListener(UpdateScoreText);
        player.OnHealthChanged.AddListener(UpdateHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateScoreText(int newScore)
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + newScore;
        }
    }

    private void UpdateHighScoreText(int newHighScore)
    {
        if (highScoreText != null)
        {
            highScoreText.text = "High Score: " + newHighScore;
        }
    }

    //METHOD TO UpdateHealth(int health)
    public void UpdateHealth(int health)
    {
        if (healthText != null)
        {
            healthText.text = "Health: " + health;
        }
    }

    //METHOD
    public void ShowGameOverScreen()
    {

    }
        //Needs to set active a Game Over Screen

    //METHOD FOR BUTTON ReturnToMainMenu()
    public void ReturnToMainMenu()
    {

    }

    //METHOD FOR BUTTON TryAgain()
    public void TryAgain()
    {

    }
}
