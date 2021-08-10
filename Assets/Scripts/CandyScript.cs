using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Increment Score
            Destroy(gameObject);
        }
        
        else if (other.gameObject.CompareTag("Deadzone"))
        {
            // Decrement Lives
            Destroy(gameObject);
        }
    }
    
    
}
