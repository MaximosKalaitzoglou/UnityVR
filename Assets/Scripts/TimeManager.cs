using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;


public class TimeManager : MonoBehaviour
{

	//this is a class for the in game timer

    //public static Action OnMinuteChanged;
    public Text timerText;
    //set a text instance timerText
    //implement getters setters for minutes and hour
    public static int Minute { get; private set; }

    public static int Hour { get; private set; }

   
    //set a timer
    public float timer;
    string hours;
    string minutes;
    string seconds;

    // Start is called before the first frame update
    void Start()
    {
    	//on start timer is 00:00:00
   
        Minute = 0;
        Hour = 0;
        timer = 0;
        timerText.text = "00:00:00";
    }

    // Update is called once per frame
    void Update()
    {
    	//increment the timer not based on real time so that we can make it go faster
        
        timer += 2*Time.deltaTime;
        
        
        //basically how clocks work ;p 
        if (timer >= 60)
        {
            Minute++;
            
            
            timer = 0;
            
        }

        if (Minute >= 60)
        {
            Hour++;
           
            Minute = 0;
        }
        
       
        if (Hour > 9)
        {
            hours = ((int)Hour).ToString();
        }
        else
        {
            hours = "0" + ((int)Hour).ToString();
        }

        if (Minute > 9)
        {
            minutes = ((int)Minute).ToString();
        }
        else
        {
            minutes = "0" + ((int)Minute).ToString();
        }

        if (timer > 9)
        {
            seconds = ((int)timer).ToString();
        }
        else
        {
            seconds = "0" + ((int)timer).ToString();
        }

        timerText.text = hours + ":" + minutes + ":" + seconds;
    }
}
