using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpawn : MonoBehaviour
{
    [SerializeField] public List<GameObject> obstacles = new List<GameObject>();
    public Transform spawnPoint;
    public float timer;

    void SpawnObstacles()
    {
        if(timer >= 3)
        {
            int randomObstacle = Random.Range(0, obstacles.Count);
            Instantiate(obstacles[randomObstacle], spawnPoint.position, Quaternion.identity);
            timer = 0;
        }
    }

    private void Update()
    {
        timer += Time.deltaTime;

        SpawnObstacles();
    }
}
