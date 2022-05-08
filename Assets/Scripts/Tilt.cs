using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour
{
    //sensitivity variable named speed
    public float speed = 2.0f;
    //vector3 for storing the input.accelaration
    Vector3 direction;

    // Update is called once per frame
    void Update()
    {
        //get direction of phone 
        direction = Input.acceleration;
        
    }

    
    
    void FixedUpdate()
    {
        //Get the current object rotation x,z (that's the ones we care about roll and pitch)
        float eulerAngX = transform.rotation.x;
        
        float eulerAngZ = transform.rotation.z;

        // rotation values for x and z where direction = phone input accelaration
        // they are inverted so  multiply by (-1)
        float moveX = -speed * direction.x * Time.deltaTime;
        float moveZ = -speed * direction.z * Time.deltaTime;
        
        //because i want my platform to not rotate upside down it will only frustrate the player basically set min=max angle rot
        
        

        if (direction.x > 0.08f)
        {
            
            //To do that we set that rotation value of gameobject < 0.3 and > -0.3
            if (eulerAngZ > -0.3)
            {
                transform.Rotate(0, 0,moveX );
            }
            // if we reach the point min-max angle point we have a problem -> meaning we can no longer control the platform so its stuck
            // so calculate new movement by players phone if its positive for negative rotation then allow the rotation
            //it is basically mathclamp but from scratch and also for phone movement ;p  
            else if (moveX > 0)
            {
                
                transform.Rotate(0, 0,moveX);
                
            }
           
        }

        if (direction.x < -0.08f){
            
            if (eulerAngZ < 0.3)
            {
                transform.Rotate(0, 0, moveX);
            }
            // so calculate new movement by players phone if its negative for positive rotation then allow the rotation 
            else if (moveX < 0)
            {
                transform.Rotate(0, 0,moveX);
                
            }
           


        }
        // Same as for X rotation 
        if (direction.z > 0.08f)
        {
            
            if (eulerAngX > -0.3)
            {
                //if the user is pitching then rotate platform X
                transform.Rotate( moveZ, 0,0);
            }
            //calculate new movement by players phone if its positive for negative rotation then allow the rotation 
            else if (moveZ > 0)
            {
                transform.Rotate(moveZ, 0, 0);
                
            }

        }

        if (direction.z < -0.08f)
        {
            
            if (eulerAngX < 0.3)
            {
                transform.Rotate( moveZ, 0,0);
            }
            //calculate new movement by players phone if its negative for positive rotation then allow the rotation 
            else if (moveZ < 0)
            {
                transform.Rotate( moveZ, 0,0);
                
            }



        }

        



        //Debug.Log("X rotation = "+ eulerAngX + "Z rotation = " + eulerAngX + "\n");
    }

    
}
