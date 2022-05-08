using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundEffect : MonoBehaviour
{
	AudioSource audioSource;

	 void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision){
    	//if the player collides with an obstacle play the sound

    	if(collision.gameObject.CompareTag("obstacle")) {
    		if (collision.relativeVelocity.magnitude > 4)
            	audioSource.Play();
        }



    	 
    
    }
}
