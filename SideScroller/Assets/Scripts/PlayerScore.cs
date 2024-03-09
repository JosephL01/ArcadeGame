using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerScore : MonoBehaviour
{
    public static PlayerScore instance;
    public int playerScore;
    public TMP_Text scoreText;
    public GameObject gameOverScreen;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public void addScore(int scoreAdded)
    {
        playerScore = playerScore + scoreAdded;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameover()
    {
        gameOverScreen.SetActive(true);
    }
}
