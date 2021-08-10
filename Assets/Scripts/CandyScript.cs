using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{

    public GameObject explosion;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Game_Manager.Instance.IncrementScore();            // increase score everytime we collide with player

            Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        
        else if (other.gameObject.CompareTag("Deadzone"))
        {
            Game_Manager.Instance.DecreaseLife();   // Decrement Lives

            Destroy(gameObject); // destroy candy
        }
    }
    
    
}
