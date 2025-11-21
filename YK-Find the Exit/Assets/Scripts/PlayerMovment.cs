using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float speed = 5;
    void Start()
    {
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
        GetComponent<Rigidbody>().velocity = Vector3.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
