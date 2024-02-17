using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpikes : MonoBehaviour
{
    [SerializeField] float obstaclesSpeed;

    void moveObstacles()
    {
        Debug.Log("Moved");
        gameObject.transform.Translate(Vector2.left * obstaclesSpeed * Time.deltaTime);  
    }

    private void Update()
    {
        moveObstacles();
    }
}
