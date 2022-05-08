using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameOver : MonoBehaviour
{
	//get a cameoverscreen component
    public GameOverScreen GameOverScreen;
    

    AudioSource audioSource;

	 void Start()
    {
    	//get audio source component save it to audioSource
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
    	//if we collide with the player
    	if(other.gameObject.CompareTag("player")) {
    		//play death sound and set up the game over screen
            //Time.timeScale = 0;
        	Debug.Log("Game Over!!!");
        	audioSource.Play();
        	GameOverScreen.Setup();
        }
    }
    
}
