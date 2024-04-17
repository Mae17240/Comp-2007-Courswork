using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    public int totalCoins; // Total number of coins in the game
    private int collectedCoins = 0; //coins collected by the player
    public string nextSceneName = "End_Screen"; 

    // when a coin is collected
    public void CollectCoin()
    {
        collectedCoins++;

        // Check if all coins are collected
        if (collectedCoins >= totalCoins)
        {
            // Trigger the end of the game
            EndTheGame();
        }
    }

    //end the game and move to the next scene (End_Screen).
    public void EndTheGame()
    {
        // Load the next scene when all coins are collected
        SceneManager.LoadScene(nextSceneName);
    }
}
