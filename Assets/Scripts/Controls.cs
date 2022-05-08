using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    // Start is called before the first frame update
    public GlobalCounter GlobalCounter;
    void Start()
    {
        GlobalCounter.Setup();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Android close icon or back button tapped.
            Application.Quit();
        }

        
    }
}
