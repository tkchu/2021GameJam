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
            text.text = string.Format("��ʷ��߷֣�{0}\n��ϲ�㴴�����µļ�¼��", history);
            PlayerPrefs.SetInt("highscore", score);
        }
        else
        {
            text.text = string.Format("��ʷ��߷֣�{0}", history);
        }
    }
}
