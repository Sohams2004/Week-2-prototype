using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : GameManager
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spike"))
        {
            Debug.Log("Game over");
            Time.timeScale = 0f;
            gameOverPanel.SetActive(true); 
        }
    }
}
