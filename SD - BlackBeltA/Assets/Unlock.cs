using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Unlock : MonoBehaviour
{
    public GameObject key;
    public GameObject lockedDoor;
    public GameObject closedDoor;
    public GameObject openDoor;
    public GameObject player;
    public string resetLevel;
    public string nextLevel;
    public Boolean A;
    public Boolean B;
    public Boolean C;
    public float x;
    public float y;
    public static int q;
    public Text deathText;
    // Start is called before the first frame update
    void Start()
    {
        A = false;
        B = false;
        C = false;
        x = transform.position.x;
        y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        deathText.text = ("" + q);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "lava")
        {
            q++;
            if (A == false)
            {
                //SceneManager.LoadScene(resetLevel);
                transform.position = new Vector2(x, y);
                key.SetActive(true);
                lockedDoor.SetActive(true);
                closedDoor.SetActive(false);
                B = false;
            }
            else
            {
                transform.position = new Vector2(x, y);
                if (C == false && B == true)
                {
                    key.SetActive(true);
                    lockedDoor.SetActive(true);
                    closedDoor.SetActive(false);
                    B = false;
                }
            }
        }               

        if (collision.tag == "checkpoint")
        {
            A = true;
            if (B == true)
            {
                C = true;
            }
            x = transform.position.x;
            y = transform.position.y;
        }

        if (collision.tag == "Key")
        {
            B = true;
            key.SetActive(false);
            lockedDoor.SetActive(false);
            closedDoor.SetActive(true);
        }

        if (collision.tag == "ClosedDoor")
        {
            closedDoor.SetActive(false);
            openDoor.SetActive(true);
        }

        if (collision.tag == "OpenDoor")
        {
            SceneManager.LoadScene(nextLevel);
        }

        if (collision.tag == "jump")
        {
            
        }
    }
}
