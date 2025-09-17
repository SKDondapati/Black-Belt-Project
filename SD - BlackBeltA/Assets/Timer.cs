using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class Timer : MonoBehaviour
{
    public static float t = 0;
    public static int time = 0;
    public int minutes = 0;
    public int seconds = 0;
    public Boolean lastScene = false;
    public Text TimerObj;
    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
            minutes = time / 60;
            seconds = time % 60;
            Debug.Log("Counter: " + time);
            Debug.Log("" + minutes + ":" + seconds);
            TimerObj.text = ("" + minutes + ":" + seconds);
        }
    }
}
