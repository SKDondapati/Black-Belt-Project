using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonMovement : MonoBehaviour
{
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = player.transform.position.x + 23.2f;
        float y = player.transform.position.y + 5.7f;
        transform.position = new Vector3(x, y, transform.position.z);
    }
}
