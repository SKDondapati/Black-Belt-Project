using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Timer : MonoBehaviour
{
    public static float t = 0;
    public static int time = 0;
    public int x = 0;
    public int minutes = 0;
    public int seconds = 0;
    public int hours = 0;
    public Boolean lastScene = false;
    public Text TimerObj;
    public Text TimerCount;
    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        x = time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            time = x;
        }

        if (lastScene == false) {
            t += Time.deltaTime;
            if (t >= 1f)
            {
                time++;
                t -= 1f;
                Debug.Log("Counter: " + time);
            }
        }
        if (lastScene == true)
        {
            Debug.Log("Counter: " + time);
            if (time > 3600)
            {
                hours = time / 3600;
                int x = time % 3600;
                minutes = x / 60;
                seconds = time % 60;
                Debug.Log("Counter: " + time);
                if (minutes >= 10) {
                    if (seconds >= 10)
                    {
                        TimerObj.text = (hours + ":" + minutes + ":" + seconds);
                    }
                    else
                    {
                        TimerObj.text = (hours + ":" + minutes + ":0" + seconds);
                    }
                } else
                {
                    if (seconds >= 10)
                    {
                        TimerObj.text = (hours + ":0" + minutes + ":" + seconds);
                    }
                    else
                    {
                        TimerObj.text = (hours + ":0" + minutes + ":0" + seconds);
                    }
                }
            }
            else
            {
                minutes = time / 60;
                seconds = time % 60;
                Debug.Log("Counter: " + time);
                if (seconds >= 10)
                {
                    TimerObj.text = (minutes + ":" + seconds);
                }
                else
                {
                    TimerObj.text = (minutes + ":0" + seconds);
                }
            }
        }
        if (time > 3600)
        {
            hours = time / 3600;
            int x = time % 3600;
            minutes = x / 60;
            seconds = time % 60;
            if (minutes >= 10)
            {
                if (seconds >= 10)
                {
                    TimerCount.text = (hours + ":" + minutes + ":" + seconds);
                }
                else
                {
                    TimerCount.text = (hours + ":" + minutes + ":0" + seconds);
                }
            }
            else
            {
                if (seconds >= 10)
                {
                    TimerCount.text = (hours + ":0" + minutes + ":" + seconds);
                }
                else
                {
                    TimerCount.text = (hours + ":0" + minutes + ":0" + seconds);
                }
            }
        }
        else
        {
            minutes = time / 60;
            seconds = time % 60;
            if (seconds >= 10)
            {
                TimerCount.text = (minutes + ":" + seconds);
            }
            else
            {
                TimerCount.text = (minutes + ":0" + seconds);
            }
        }
    }
}
