using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUpScreen : MonoBehaviour
{
    float highScore;
    public TextMeshProUGUI highScoreText;

    private void Start()
    {
        highScore = PlayerPrefs.GetFloat("HighScore");
        highScoreText.text = "High Score : " + Mathf.Round(highScore);
        Debug.Log(highScore);
        Time.timeScale = 1.0f;
    }

    void Play()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.buildIndex + 1) ;
        }
    }

    private void Update()
    {
        Play();
    }
}
