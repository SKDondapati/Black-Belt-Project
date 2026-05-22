using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicker : MonoBehaviour
{
    public GameObject helpMenu;
    private void OnMouseDown()
    {
        if (helpMenu.activeSelf == true)
        {
            helpMenu.SetActive(false);
        }
        else
        {
            helpMenu.SetActive(true);
        }
    }
}
