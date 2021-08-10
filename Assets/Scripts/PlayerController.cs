using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool _canMove = true;


    [SerializeField] private float maxPos; // We need to check the borders of player when goes left. so that we can take that position as border
    [SerializeField ]private float speed;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_canMove)
        {
            Move();
        }
    }

    void Move()
    {
        float xInput = Input.GetAxis("Horizontal"); // returns value how much we press left or right arrow key
        
        transform.position += Vector3.right * xInput * speed * Time.deltaTime; // move positive x axis, careful, its "+=". We are adding on it.

        float xPos = Mathf.Clamp(transform.position.x, -maxPos, maxPos); // Restricting the X position because we only move on X and storing it

        transform.position = new Vector3(xPos, transform.position.y, transform.position.z); 
    }
}
