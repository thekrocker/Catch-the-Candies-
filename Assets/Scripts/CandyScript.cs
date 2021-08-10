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
            Game_Manager.Instance.IncrementScore(); // increase score everytime we collide with player
            Destroy(gameObject);
        }
        
        else if (other.gameObject.CompareTag("Deadzone"))
        {
            // Decrement Lives
            Destroy(gameObject);
        }
    }
    
    
}
