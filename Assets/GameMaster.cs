using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameMaster : MonoBehaviour
{
    public GameObject blackScreen;
    public bool isPlaying = false;
    public int gameState = 0;//0:title,1:game,2:fail,3:success
    public float scoreNow = 0;
    public float scorePreSecond = 100;

    public float leftTimeNow = 60;
    public float leftTime = 60;

    public GameObject title;
    public GameObject fail;
    public GameObject success;
    public void Restart()
    {
        title.SetActive(false);
        fail.SetActive(false);
        success.SetActive(false);
        scoreNow = 0;
        leftTimeNow = leftTime;

        gameState = 1;
    }

    private void Start()
    {
        blackScreen.SetActive(true);
    }
    void Update()
    {
        if (gameState == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                title.SetActive(false);
                gameState = 1;
            }
        }else if (gameState == 1)
        {
            leftTimeNow -= Time.deltaTime;
            if (leftTimeNow <= 0)
            {
                gameState = 3;
                success.SetActive(true);
            }

            isPlaying = Input.GetKey(KeyCode.Space);
            blackScreen.SetActive(!isPlaying);
            if (isPlaying)
            {
                scoreNow += scorePreSecond * Time.deltaTime;
            }
        }else if(gameState == 2)
        {

        }else if(gameState == 3)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Restart();
            }

        }
    }

}
