using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeHelp : MonoBehaviour
{
    public GameObject helpMenu;
    public GameObject pauseMenu;

    public void ok()
    {
        helpMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
