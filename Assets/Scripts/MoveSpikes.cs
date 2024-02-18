using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpikes : MonoBehaviour
{
    [SerializeField] float obstaclesSpeed, destroyTimer;

    void moveObstacles()
    {
        Debug.Log("Moved");
        gameObject.transform.Translate(Vector2.left * obstaclesSpeed * Time.deltaTime);  
    }

    void DestroySpike()
    {
        destroyTimer += Time.deltaTime;
        if (destroyTimer >= 10)
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        DestroySpike();
        moveObstacles();
    }
}
