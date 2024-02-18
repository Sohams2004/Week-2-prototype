using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gamePausePanel;
    [SerializeField] public GameObject gameOverPanel;

    private void Start()
    {
        Time.timeScale = 1.0f;
    }

    void PauseGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            gamePausePanel.SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1f;
            gamePausePanel.SetActive(false);
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        gamePausePanel.SetActive(false);
    }

    private void Update()
    {
        PauseGame();
    }
}
