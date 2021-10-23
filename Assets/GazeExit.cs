using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeExit : MonoBehaviour
{
    public GameObject InfoObject;
    private bool Show = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ExitApp()
    {
        if (Show == true)
        {
            Application.Quit();
        }
    }
}
