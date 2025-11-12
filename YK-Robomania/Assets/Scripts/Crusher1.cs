using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crusher1 : MonoBehaviour
{
    public float speed;
    private void FixedUpdate()
    {
        float newXPosition = transform.position.x + speed * Time.fixedDeltaTime;
        float newYPosition = transform.position.y;
        Vector2 newPosition = new Vector2(newXPosition, newYPosition);
        transform.position = newPosition;
    }
}
