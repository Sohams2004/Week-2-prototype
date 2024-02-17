using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesMove : MonoBehaviour
{
    [SerializeField] List<GameObject> obstacles = new List<GameObject>();
    [SerializeField] float obstaclesSpeed;

    void moveObstacles()
    {
        for (int i = 0; i < obstacles.Count; i++)
        {
            obstacles[i].transform.Translate(Vector2.left * obstaclesSpeed * Time.deltaTime); 
        }
    }

    private void Update()
    {
        moveObstacles();
    }
}
