using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : GameManager
{
    Score score;

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
            //gameOverPanel.SetActive(true);
            if(score.scoreCount > oldHighScore)
            {
                PlayerPrefs.SetFloat("HighScore", score.scoreCount);
            }
            Time.timeScale = 0f;
        }
    }
}
