using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Game : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        // Check if the ESC key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            if (isPaused)
            {
                Time.timeScale = 0f; // Pauses the game
            }
            else 
            {
                Time.timeScale = 1f; 
            }
        }
    }
}
