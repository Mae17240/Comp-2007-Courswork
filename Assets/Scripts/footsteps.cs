using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
    public AudioSource footstepsSounds, sprintSound;

    void Update()
    {
        //checking if the directional inputs have been pressed. 
        if (Input.GetKey(KeyCode.W) || (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.S)) )){
            if (Input.GetKey(KeyCode.LeftShift)) //sprint key
            {
                footstepsSounds.enabled = false; //disable walking sounds
                sprintSound.enabled = true; //enable sprint sound 
            }
        }
        else
        {
            footstepsSounds.enabled = false;
            sprintSound.enabled = false;   
        }
    }
}
