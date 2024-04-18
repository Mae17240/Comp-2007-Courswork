using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    public int totalCoins; // Total number of coins in the game
    private int collectedCoins = 0; // Coins collected by the player
    public Timer_script timer; // Reference to your timer script

    // When a coin is collected
    public void CollectCoin()
    {
        collectedCoins++;

        // Check if all coins are collected
        if (collectedCoins >= totalCoins)
        {
            // Trigger any end game actions here if needed
        }
    }

    // End the game
    public void EndTheGame()
    {
        // Stop the timer
        timer.timeRunning = false;

        // Trigger any end game actions here if needed
    }
}
