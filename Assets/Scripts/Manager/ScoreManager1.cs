using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class ScoreManager1 : MonoBehaviour
{
    [SerializeField] private int highestScore;
    [SerializeField] private int totalScore;
    [SerializeField] private TextMeshProUGUI totalScoreText; // Reference to the UI Text component for displaying the total score
    [SerializeField] private TextMeshProUGUI highestScoreText; // Reference to the UI Text component for displaying the highest score
    [SerializeField] private TextMeshProUGUI gameOverHighScoreText; // Reference to the UI Text component for displaying the high score at game over

    public UnityEvent<int> OnTotalScoreChanged = new UnityEvent<int>();
    public UnityEvent<int> OnHighestScoreChanged = new UnityEvent<int>();
    public static ScoreManager1 singleton;

    private void Awake()
    {
        singleton = this;
        totalScore = PlayerPrefs.GetInt("HSCORE"); //
        highestScore = PlayerPrefs.GetInt("HighScore"); // retrieving save file with name HighScore
        OnHighestScoreChanged.Invoke(highestScore);
        UpdateHighestScoreText(); // Update the highest score text on UI
    }

    private void Start()
    {
        OnTotalScoreChanged.AddListener(UpdateTotalScoreText);
        OnHighestScoreChanged.AddListener(UpdateHighestScoreText);
    }

    public void RegisterHighScore()
    {
        if (totalScore > highestScore) // when get higher score
        {
            PlayerPrefs.SetInt("HighScore", totalScore); // save score in player prefs
            highestScore = totalScore;
            OnHighestScoreChanged.Invoke(highestScore);
        }
    }

    public void IncreaseScore()
    {
        totalScore += 1;
        OnTotalScoreChanged.Invoke(totalScore);
    }

    private void UpdateTotalScoreText(int newTotalScore)
    {
        if (totalScoreText != null)
        {
            totalScoreText.text = "Score: " + newTotalScore;
        }
    }

    private void UpdateHighestScoreText(int newHighestScore)
    {
        if (highestScoreText != null)
        {
            highestScoreText.text = "High Score: " + newHighestScore;
        }
    }

    private void UpdateHighestScoreText() // Overloaded method to handle initial update
    {
        if (highestScoreText != null)
        {
            highestScoreText.text = "High Score: " + highestScore;
        }
    }

    public void DisplayHighScoreOnGameOver()
    {
        if (gameOverHighScoreText != null)
        {
            gameOverHighScoreText.text = "High Score: " + highestScore;
            gameOverHighScoreText.gameObject.SetActive(true); // Make sure the game over text is visible
        }
    }
}



//using System.Collections;
//using System.Collections.Generic;
//using Unity.VisualScripting;
//using UnityEngine;
//using UnityEngine.Events;

//public class ScoreManager1 : MonoBehaviour
//{
//    [SerializeField] private int highestScore;
//    [SerializeField] private int totalScore;

//    public UnityEvent<int> OnTotalScoreChanged = new UnityEvent<int>();
//    public UnityEvent<int> OnHighestScoreChanged = new UnityEvent<int>();
//    public static ScoreManager1 singleton;

//    private void Awake()
//    {
//        singleton = this;
//        highestScore = PlayerPrefs.GetInt("HighScore"); // retrieving save file with name HighScore
//        OnHighestScoreChanged.Invoke(highestScore);
//    }

//    private void Start()
//    {

//    }

//    public void RegisterHighScore()
//    {
//        if (totalScore > highestScore) //when get higher score
//        {
//            PlayerPrefs.SetInt("HighScore", totalScore); //save score in player prefs
//            highestScore = totalScore;
//            OnHighestScoreChanged.Invoke(highestScore);
//        }
//    }
//    public void IncreaseScore()
//    {
//        totalScore += 1;    
//        OnTotalScoreChanged.Invoke(totalScore);
//    }


//}
