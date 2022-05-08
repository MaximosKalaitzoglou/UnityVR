using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class Gaze : MonoBehaviour
{
    //boolean for knowing if we are still looking at object or not 
    bool status;

    
    //timer for event to happen at 0 the object is destroyed
    public float timer = 4;
    //used to store the original color of the object
    Color colorStart;
    

    private void Start()
    {
        //store original object color
        colorStart = GetComponent<Renderer>().material.color;
        
    }

    void Update()
    {
        if (TimeManager.Minute == 1)
        {
            //if we are looking
            if (status == true)
            {
                //decrease timer
                timer -= Time.deltaTime;
                //if timer <= 0 destroy object
                if (timer <= 0)
                {
                    Destroy(gameObject);
                }
            }
        }
        

        
    }


    // The functions below are tied to the event system PointerEnter and PointerExit respectively

    // So when we enter looking is called 
    // set status to true -> looking 

    public void LookingAtObstacle()
    {
        status = true;
        //change object color while looking 
        GetComponent<Renderer>().material.color = Color.blue;
        Debug.Log("I am looking at you !!!!");

    }

    //When we exit notLooking is called
    // if we are not looking at the object anymore reset timer set status to false and change color back to the original
    public void NotLookingAtObstacle()
    {
        status = false;
        timer = 4;
        GetComponent<Renderer>().material.color = colorStart;
        Debug.Log("I am not looking at you !!!!");
    }

    
}

    

