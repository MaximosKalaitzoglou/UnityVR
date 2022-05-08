using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

	private bool status = false;
	private string mode;
	public float timer = 3;

    public void Setup(){
    	//Time.timeScale = 0;
    	gameObject.SetActive(true);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void RestartButton(){
    	status = true;
    	mode = "restart";
    	//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void QuitButton(){
    	status = true;
    	mode = "quit";
    	//Application.Quit();
    }

    public void ExitButton(){
    	status = false;
    	timer = 3;
    }

    public void PlayButton(){
    	status = true;
    	mode = "play";
    }

     public void NextButton(){
        status = true;
        mode = "Next";
    }

     void Update()
    {
        
            //if we are looking
        if (status == true)
        {
                //decrease timer
            timer -= Time.deltaTime;
                //if timer <= 0 destroy object
            if (timer <= 0)
            {
            	if (mode == "quit"){
            		Application.Quit();
            	}
                
                if (mode == "restart"){
                	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }

                if(mode == "play"){
                	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
                }

                if(mode == "Next"){
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
                }
            }
        }
        
    }
     
    
}
