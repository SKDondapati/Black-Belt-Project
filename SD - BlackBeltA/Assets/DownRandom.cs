using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownRandom : MonoBehaviour
{
    public float speed;
    public float distance;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
        speed = Random.Range(1, 4);
        distance = Random.Range(1, 30);
    }

    void Update()
    {
        float offset = Mathf.PingPong(Time.time * speed, distance);
        transform.position = startPosition + new Vector3(0, -offset, 0);
    }
}
