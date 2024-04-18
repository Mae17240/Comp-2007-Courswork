using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class collectable : MonoBehaviour
{
    public static event System.Action onCollected;
    public static int TotalCoinsCollected = 0; // Initialize to 0
    public Game_Manager gameManager;

    void Awake()
    {
        TotalCoinsCollected++; // Increment total coins when a collectable is created
    }

    void Update()
    {
        transform.rotation = Quaternion.Euler(0f, Time.time * 100f, 0f); // Rotation for the collectible object
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onCollected?.Invoke();
            Destroy(gameObject); // Destroy the collectible object once collected
        }
    }
}
