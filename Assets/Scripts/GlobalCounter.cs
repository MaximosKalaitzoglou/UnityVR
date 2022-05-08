using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalCounter : MonoBehaviour
{
    //global counter used for counting how many balls each level has
    // so that the player has to put every ball in the right hole to ultimately win
    public static int Counter{get; set;}
    //one ball levels
    private string[] oneGoalScenes = { "Tutorial", "Level1", "Level5" };
    //2 ball levels
    private string[] twoGoalScenes = { "Level2", "Level3" };
    //3 ball levels
    private string[] threeGoalScenes = { "Level4"};

    public void Setup(){
        //initialize global counter based on level 
        Scene scene = SceneManager.GetActiveScene();
       

        if (oneGoalScenes.Contains(scene.name)){
    		Counter = 1;
    		Debug.Log("Hey from global");
    	}

    	if (twoGoalScenes.Contains(scene.name)){
    		Counter = 2;
    		Debug.Log("Hey from global");
    	}

    	if (threeGoalScenes.Contains(scene.name)){
    		Counter = 3;
    		Debug.Log("Hey from global");
    	}

    	Debug.Log("Global counter = " + Counter);


    }
}
