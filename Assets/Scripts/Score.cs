using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] public float scoreCount;
    [SerializeField] TextMeshProUGUI scoreText ;

    IEnumerator ScoreIncrease()
    {
        yield return new WaitForSeconds(3);
        scoreCount += Time.deltaTime * 10;
        scoreText.text = string.Format("Score : " + Mathf.Round(scoreCount));
    }

    private void Update()
    {
        StartCoroutine(ScoreIncrease());
    }
}
