using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{

    public float threshiold;

    
    void FixedUpdate()
    {
        if (transform.position.y < threshiold)
        {
            transform.position = new Vector3(10.2f, 1.57f, 8.92f); //resets the player back to the starting co-ordinates.
        }
    }
}
