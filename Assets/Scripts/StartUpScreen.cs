using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartUpScreen : MonoBehaviour
{
    float highScore;
    public TextMeshProUGUI highScoreText;

    private void Start()
    {
        highScore = PlayerPrefs.GetFloat("HighScore");
        highScoreText.text = "High Score : " + Mathf.Round(highScore);
        Debug.Log(highScore);
    }
}
