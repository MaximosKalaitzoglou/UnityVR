using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
	 Color colorOfTrap;
	//save color of trap and set a counter to use after the color has changed 

	 public int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        colorOfTrap = GetComponent<Renderer>().material.color;
        
    }

    private void OnTriggerEnter(Collider other){
    	if(other.gameObject.CompareTag("player")){
    		if(counter == 0){
    			//if we collide with the player we change his color and then increment the counter
    			//since the counter is > 0 it doesn;t continiously change the color of the player
    			other.GetComponent<Renderer>().material.color = colorOfTrap;
    			counter++;
    		}

    		
    	}
    }
}
