using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalCounter : MonoBehaviour
{

    public static int Counter{get; set;}
    private string[] oneGoalScenes = { "Tutorial", "Level1", "Level5" };
    private string[] twoGoalScenes = { "Level2", "Level3" };
    private string[] threeGoalScenes = { "Level4"};

    public void Setup(){
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
