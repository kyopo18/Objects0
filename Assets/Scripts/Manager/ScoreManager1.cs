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
     

    public UnityEvent<int> OnTotalScoreChanged = new UnityEvent<int>();
    public UnityEvent<int> OnHighestScoreChanged = new UnityEvent<int>();
    public static ScoreManager1 singleton;

    private void Awake()
    {
        singleton = this;
        totalScore = PlayerPrefs.GetInt("HSCORE"); //
        highestScore = PlayerPrefs.GetInt("HighScore"); // retrieving save file with name HighScore
        
        
    }

    private void Start()
    {
        Invoke("LateStart", Time.deltaTime * 2);
    }

    private void LateStart()
    {
        OnHighestScoreChanged.Invoke(highestScore);
        OnTotalScoreChanged.Invoke(totalScore);
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
}
