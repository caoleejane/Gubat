using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    [SerializeField]
    private GameObject obstaclePrefab;

    private float startTime = 1;
    private float waveTime = 3;

    private Vector3 randomPosition;

    void Update()
    {
        if (Time.time > startTime){
            randomPosition = new Vector3(Random.Range(-10f, -15f), 0f, 0f);
            Instantiate(obstaclePrefab, transform.position + randomPosition, Quaternion.identity);
            startTime = Time.time + waveTime;
        }
    }
}
