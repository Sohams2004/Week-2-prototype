using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySpikes : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("dqd");
        if (other.gameObject.CompareTag("Spike"))
        {
            Destroy(other.gameObject);
        }
    }
}
