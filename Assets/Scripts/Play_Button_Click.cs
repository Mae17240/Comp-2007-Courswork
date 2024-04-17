using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Button_Click : MonoBehaviour
{
    public AudioSource playSound;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playSoundEffect()
    {
        playSound.Play();
    }
}
