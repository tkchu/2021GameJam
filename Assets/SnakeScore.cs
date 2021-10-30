using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnakeScore : MonoBehaviour
{
    public SnakeGame snakeGame;
    public Text scoreText;
    public Text levelText;

    private void LateUpdate()
    {
        scoreText.text = string.Format("SCORE {0:000}", snakeGame.score);
        levelText.text = string.Format("LEVEL {0:00}", snakeGame.mult);
    }
}
