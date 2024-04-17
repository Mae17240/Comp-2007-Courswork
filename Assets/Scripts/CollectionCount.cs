using TMPro;
using UnityEngine;

public class CollectionCount : MonoBehaviour
{
    TMPro.TMP_Text text;
    int count;

    public Game_Manager Game_Manager; // Reference to the Game_Manager script

    void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }

    void Start() => updateCount();

    void OnEnable() => collectable.onCollected += onCollectableCollected;
    void OnDisable() => collectable.onCollected -= onCollectableCollected;

    void onCollectableCollected()
    {
        count++;
        updateCount();

        // Check if all coins are collected
        if (count >= collectable.TotalCoinsCollected)
        {
            // Trigger the end of the game
            Game_Manager.EndTheGame(); 
        }
    }

    void updateCount()
    {
        text.text = $"{count} / {collectable.TotalCoinsCollected}"; // updates the texc to show how many coins the user has collected.
    }
}
