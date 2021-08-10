using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{

    public static Game_Manager Instance;
    public int score = 0;

    private bool _gameOver = false;

    public Text scoreText;
    
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScore()
    {
        score++;
        scoreText.text = score.ToString();
        print(score); // lets see if score's working.
        
    }
}
