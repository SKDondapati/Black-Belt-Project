using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;
using System.Linq.Expressions;

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
    /*public Boolean D;
    public Boolean E;
    public Boolean F;
    public Boolean G;*/
    public float x;
    public float y;
    public static int q;
    public int death;
    public Text deathText;
    public GameObject redFlag;
    public GameObject greenFlag;
    public GameObject redFlag1;
    public GameObject greenFlag1;
    public GameObject redFlag2;
    public GameObject greenFlag2;
    public GameObject redFlag3;
    public GameObject greenFlag3;
    public GameObject redFlag4;
    public GameObject greenFlag4;
    public GameObject redFlag5;
    public GameObject greenFlag5;
    /*public GameObject jump;
    public GameObject speed;*/
    // Start is called before the first frame update
    void Start()
    {
        A = false;
        B = false;
        C = false;
        /*D = false;
        E = false;
        F = false;
        G = false;*/
        x = transform.position.x;
        y = transform.position.y;
        death = q;
    }

    // Update is called once per frame
    void Update()
    {
        deathText.text = ("" + q);
        if (Input.GetKeyDown(KeyCode.R))
        {
            q = death;
            SceneManager.LoadScene(resetLevel);
        }
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

        /*if (collision.tag == "checkpoint")
        {
            A = true;
            if (B == true)
            {
                C = true;
            }
            x = transform.position.x;
            y = transform.position.y;
        }*/

        if (collision.tag == "Key")
        {
            B = true;
            key.SetActive(false);
            lockedDoor.SetActive(false);
            closedDoor.SetActive(true);
        }

       /*f (collision.tag == "jump")
        {
            D = true;
            jump.SetActive(false);
        }

        if (collision.tag == "speed")
        {
            
            speed.SetActive(false);
        }*/

        if (collision.tag == "ClosedDoor")
        {
            closedDoor.SetActive(false);
            openDoor.SetActive(true);
        }

        if (collision.tag == "OpenDoor")
        {
            SceneManager.LoadScene(nextLevel);
        }

        

        if (collision.tag == "flag")
        {
            A = true;
            if (B == true)
            {
                C = true;
            }
            /*if (D == true)
            {
                F = true;
            }
            if (E == true)
            {
                G = true;
            }*/
            
            x = transform.position.x;
            y = transform.position.y;
            redFlag.SetActive(false);
            greenFlag.SetActive(true);
            redFlag1.SetActive(true);
            greenFlag1.SetActive(false);
            redFlag2.SetActive(true);
            greenFlag2.SetActive(false);
            redFlag3.SetActive(true);
            greenFlag3.SetActive(false);
            redFlag4.SetActive(true);
            greenFlag4.SetActive(false);
        }

        if (collision.tag == "flag1")
        {
            A = true;
            if (B == true)
            {
                C = true;
            }

            x = transform.position.x;
            y = transform.position.y;
            redFlag.SetActive(true);
            greenFlag.SetActive(false);
            redFlag1.SetActive(false);
            greenFlag1.SetActive(true);
            redFlag2.SetActive(true);
            greenFlag2.SetActive(false);
            redFlag3.SetActive(true);
            greenFlag3.SetActive(false);
            redFlag4.SetActive(true);
            greenFlag4.SetActive(false);
        }

        if (collision.tag == "flag2")
        {
            A = true;
            if (B == true)
            {
                C = true;
            }
            
            x = transform.position.x;
            y = transform.position.y;
            redFlag.SetActive(true);
            greenFlag.SetActive(false);
            redFlag1.SetActive(true);
            greenFlag1.SetActive(false);
            redFlag2.SetActive(false);
            greenFlag2.SetActive(true);
            redFlag3.SetActive(true);
            greenFlag3.SetActive(false);
            redFlag4.SetActive(true);
            greenFlag4.SetActive(false);
        }

        if (collision.tag == "flag3")
        {
            A = true;
            if (B == true)
            {
                C = true;
            }
            x = transform.position.x;
            y = transform.position.y;
            redFlag.SetActive(true);
            greenFlag.SetActive(false);
            redFlag1.SetActive(true);
            greenFlag1.SetActive(false);
            redFlag2.SetActive(true);
            greenFlag2.SetActive(false);
            redFlag3.SetActive(false);
            greenFlag3.SetActive(true);
            redFlag4.SetActive(true);
            greenFlag4.SetActive(false);
        }

        if (collision.tag == "flag4")
        {
            A = true;
            if (B == true)
            {
                C = true;
            }
            x = transform.position.x;
            y = transform.position.y;
            redFlag.SetActive(true);
            greenFlag.SetActive(false);
            redFlag1.SetActive(true);
            greenFlag1.SetActive(false);
            redFlag2.SetActive(true);
            greenFlag2.SetActive(false);
            redFlag3.SetActive(true);
            greenFlag3.SetActive(false);
            redFlag4.SetActive(false);
            greenFlag4.SetActive(true);
        }

        if (collision.tag == "flag5")
        {
            A = true;
            if (B == true)
            {
                C = true;
            }
            x = transform.position.x;
            y = transform.position.y;
            redFlag.SetActive(true);
            greenFlag.SetActive(false);
            redFlag1.SetActive(true);
            greenFlag1.SetActive(false);
            redFlag2.SetActive(true);
            greenFlag2.SetActive(false);
            redFlag3.SetActive(true);
            greenFlag3.SetActive(false);
            redFlag4.SetActive(true);
            greenFlag4.SetActive(false);
            redFlag5.SetActive(false);
            greenFlag5.SetActive(true);
        }
    }
}
