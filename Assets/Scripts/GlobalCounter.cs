using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalCounter : MonoBehaviour
{

    public static int Counter{get; set;}

    public void Setup(){
    	if (SceneManager.GetActiveScene().buildIndex < 2 || SceneManager.GetActiveScene().buildIndex == 6){
    		Counter = 1;
    		Debug.Log("Hey from global");
    	}

    	if (SceneManager.GetActiveScene().buildIndex == 3 ||SceneManager.GetActiveScene().buildIndex == 4 ){
    		Counter = 2;
    		Debug.Log("Hey from global");
    	}

    	if (SceneManager.GetActiveScene().buildIndex == 5){
    		Counter = 3;
    		Debug.Log("Hey from global");
    	}

    	Debug.Log("Global counter = " + Counter);


    }
}
