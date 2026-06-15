using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackBoxMovement : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = player.transform.position.x + 0.2f;
        float y = player.transform.position.y + 0.5f;
        transform.position = new Vector3(x, y, transform.position.z);
    }
}
