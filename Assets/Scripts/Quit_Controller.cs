using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit_Controller : MonoBehaviour
{
    public string firstSceneName = "Main_Menu";

    void Update()
    {
        // Check if the 'q' key is pressed
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Load the first scene
            SceneManager.LoadScene(firstSceneName);
        }
    }
}

