using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerScore : MonoBehaviour
{
    public int playerScore;
    public TMP_Text scoreText;

    public void addScore(int scoreAdded)
    {
        playerScore = playerScore + scoreAdded;
        scoreText.text = playerScore.ToString();
    }
}
