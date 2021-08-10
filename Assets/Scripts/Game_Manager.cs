using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{

    public static Game_Manager Instance;

    public GameObject livesHolder;
    public Text scoreText;
    public GameObject gameOverPanel;

    
    private int _score = 0;
    private int _lives = 3;
    private bool _gameOver = false;

    
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

        if (!_gameOver)
        {
            _score++;
            scoreText.text = _score.ToString();
            
            // print(_score);
        }

        
    }

    public void DecreaseLife()
    {
        if (_lives > 0)
        {
            _lives--;
            
            print(_lives);

            livesHolder.transform.GetChild(_lives).gameObject.SetActive(false);

        }

        if (_lives <= 0)
        {
            _gameOver = true;

            GameOver();
        }
        
    }

    public void GameOver()
    {
        CandySpawner.instance.StopSpawningCandies();
        GameObject.Find("Player").GetComponent<PlayerController>().canMove = false;
        gameOverPanel.SetActive(true);
        
        // print("Gameover");
    }


    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
