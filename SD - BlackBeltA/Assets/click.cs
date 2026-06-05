using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    public GameObject play;
    public GameObject pause;
    public GameObject back;
    //public GameObject dimmer;
    public GameObject pauseMenu;
    public GameObject helpMenu;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        //helpMenu.SetActive(false);
        if (helpMenu.activeSelf == false)
        {
            if (play.activeSelf == true)
            {
                back.SetActive(false);
                play.SetActive(false);
                back.SetActive(true);
                pause.SetActive(true);
                //dimmer.SetActive(false);
                pauseMenu.SetActive(false);
                Time.timeScale = 1f;
            }
            else
            {
                //dimmer.SetActive(true);
                back.SetActive(false);
                pause.SetActive(false);
                back.SetActive(true);
                play.SetActive(true);
                pauseMenu.SetActive(true);
                Time.timeScale = 0f;
            }
        }
        
    }
}
