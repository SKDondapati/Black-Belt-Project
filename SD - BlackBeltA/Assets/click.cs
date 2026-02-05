using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    public GameObject play;
    public GameObject pause;
    public GameObject back;
  
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
        if (play.activeSelf == true)
        {
            back.SetActive(false);
            play.SetActive(false);
            back.SetActive(true);
            pause.SetActive(true);
            Time.timeScale = 1f;
        } else
        {
            back.SetActive(false);
            pause.SetActive(false);
            back.SetActive(true);
            play.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
