using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpawn : MonoBehaviour
{
    [SerializeField] public List<GameObject> obstacles = new List<GameObject>();
    [SerializeField] Score score;
    public Transform spawnPoint;
    public float timer, spikeCount;

    private void Start()
    {
        score = FindObjectOfType<Score>();
    }

    void SpawnObstacles()
    {
        if(timer >= spikeCount)
        {
            int randomObstacle = Random.Range(0, obstacles.Count);
            Instantiate(obstacles[randomObstacle], spawnPoint.position, Quaternion.identity);
            timer = 0;
        }
    }

    void IncreaseSpikeRate()
    {
        if(score.scoreCount >= 500)
            spikeCount = 2;

        if(score.scoreCount >= 1000)
            spikeCount = 1.5f;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        SpawnObstacles();
        IncreaseSpikeRate();
    }
}
