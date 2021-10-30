using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuccessPage : MonoBehaviour
{
    public Text scoreText;

    public GameMaster gameMaster;

    string scoreS = "×îÖÕµÃ·Ö£º{0}";

    private void OnEnable()
    {
        scoreText.text = string.Format(scoreS, gameMaster.score);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            gameMaster.Restart();
        }
    }
}
