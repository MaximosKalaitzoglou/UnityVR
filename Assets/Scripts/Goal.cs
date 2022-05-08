using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    //audiosource for sound colorOfgoal is used to check if sphere and goal have the same color
    //meaning that each goal corresponds to a specific sphere based on its color scheme
    
    AudioSource audioSource;
    Color colorOfgoal;
    public GameOverScreen GameOverScreen;
    public Text GameOver;
    public GameObject NextButton;


    
    //public LoadNextScene LoadNextScene;

     void Start()
    {
        audioSource = GetComponent<AudioSource>();
        colorOfgoal = GetComponent<Renderer>().material.color;
       


    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("player")){
        	//Application.Quit();
            if(other.GetComponent<Renderer>().material.color == colorOfgoal){
                Debug.Log("GOAL REACHED!!!");
                GlobalCounter.Counter-= 1;
                Debug.Log( GlobalCounter.Counter);

                if(GlobalCounter.Counter == 0){
                	//Time.timeScale = 0;
                	audioSource.Play();
                	GameOver.text = "WELL DONE!!";
                	NextButton.SetActive(true);
                	GameOverScreen.Setup();
                }
                
                //WinScreen.Setup();
                //StartCoroutine(Waiter(other));
            }else{
                
                GameOverScreen.Setup();
            }
        }
        
        
        

    }
    /*
    //used to have a slight delay after the goal is reached
    IEnumerator Waiter(Collider other)
    {
        yield return new WaitForSeconds(3);
        Destroy(other.gameObject);
        Debug.Log("Object destroyed!!!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    */
}
