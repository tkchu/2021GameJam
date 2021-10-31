using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    GameMaster gameMaster;
    Text text;
    private void Awake()
    {
        gameMaster = FindObjectOfType<GameMaster>();
        text = GetComponent<Text>();
    }
    private void OnEnable()
    {
        int history = PlayerPrefs.GetInt("highscore", 0);

        int score =(int) gameMaster.score;
        if (history <= score)
        {
            text.text = string.Format("历史最高分：{0}\n恭喜你创造了新的记录！", history);
            PlayerPrefs.SetInt("highscore", score);
        }
        else
        {
            text.text = string.Format("历史最高分：{0}", history);
        }
    }
}
