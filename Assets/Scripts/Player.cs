using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : GameManager
{
    Score score;
    public TextMeshProUGUI currentScoreText;
    public TextMeshProUGUI highScoreText;

    private void Start()
    {
        score = FindObjectOfType<Score>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spike"))
        {
            float oldHighScore = PlayerPrefs.GetFloat("HighScore");

            Debug.Log("Game over");
            gameOverPanel.SetActive(true);
            if(score.scoreCount > oldHighScore)
            {
                PlayerPrefs.SetFloat("HighScore", score.scoreCount);
            }

            currentScoreText.text = "Current Score : " + Mathf.Round(score.scoreCount);
            highScoreText.text = "High Score : " + Mathf.Round(oldHighScore);
            Time.timeScale = 0f;
        }
    }
}
