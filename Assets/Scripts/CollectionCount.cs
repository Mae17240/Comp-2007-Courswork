using TMPro;
using UnityEngine;

public class CollectionCount : MonoBehaviour
{
    TMPro.TMP_Text text;
    int count;

    public Game_Manager Game_Manager; // Reference to the Game_Manager script
    public collectable collectable; // Reference to the Collectable script or object containing total coins collected

    void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }

    void Start()
    {
        UpdateCount();
    }

    void OnEnable()
    {
        collectable.onCollected += OnCollectableCollected;
    }

    void OnDisable()
    {
        collectable.onCollected -= OnCollectableCollected;
    }

    void OnCollectableCollected()
    {
        count++;
        UpdateCount();

        // Check if all coins are collected
        if (count >= collectable.TotalCoinsCollected)
        {
            // Trigger the end of the game
            Game_Manager.EndTheGame();
        }
    }

    void UpdateCount()
    {
        text.text = $"{count} / {collectable.TotalCoinsCollected}"; // updates the text to show how many coins the user has collected.
    }
}
