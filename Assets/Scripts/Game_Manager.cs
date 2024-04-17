using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    public int totalCoins; // Total number of coins in the game
    private int collectedCoins = 0; // Number of coins collected by the player
    public string nextSceneName = "End_Screen"; // Name of the scene to load when all coins are collected

    // Function to call when a coin is collected
    public void CollectCoin()
    {
        // Increment the collected coins count
        collectedCoins++;

        // Check if all coins are collected
        if (collectedCoins >= totalCoins)
        {
            // Trigger the end of the game
            EndTheGame();
        }
    }

    // Function to end the game
    public void EndTheGame()
    {
        // Load the next scene when all coins are collected
        SceneManager.LoadScene(nextSceneName);
    }
}
