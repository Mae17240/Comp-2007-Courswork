using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
    public static event Action onCollected;
    public static int TotalCoinsCollected;

    void Awake() => TotalCoinsCollected++;

    void Update()
    {
        transform.rotation = Quaternion.Euler(0f, Time.time * 100f, 0f);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onCollected?.Invoke();
            Destroy(gameObject);
        }
        
    }
}
