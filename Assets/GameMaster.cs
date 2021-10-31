using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public GameObject blackScreen;
    public bool isPlaying = false;


    public float score = 0;
    private void Start()
    {
        Screen.fullScreen = false;
        blackScreen.SetActive(true);
    }
    float playTime = 0;
    float playTimeAll = 0;
    void Update()
    {
        isPlaying = !Input.GetKey(KeyCode.Space);
        blackScreen.SetActive(!isPlaying);

        if (isPlaying)
        {
            playTime += Time.deltaTime;
            playTimeAll += Time.deltaTime;
            while (playTime > 1)
            {
                playTime -= 1;
                AddScore(10);
            }
        }


        leftTime -= Time.deltaTime;
        if (leftTime <= 0)
        {
            Succ();
        }
    }

    public void EatApple(int level)
    {
        AddScore(100 * level);
    }

    public float leftTime = 60;
    public SnakeGame snakeGame;
    public Notice fatherNotice;
    public FatherDoing fatherDoing;
    public void Restart()
    {
        SceneManager.LoadScene("main");
        score = 0;
        playTime = 0;
        leftTime = 60;
        snakeGame.ReStart();
        fatherNotice.Restart();
        fatherDoing.Restart();
        successPage.SetActive(false);
        failedPage.SetActive(false);
    }
    public void Succ()
    {
        snakeGame.enabled = false;
        fatherNotice.enabled = false;
        fatherDoing.enabled = false;
        snakeGame.enabled = false;
        StartCoroutine(Success());
    }
    public void Failed()
    {
        snakeGame.enabled = false;
        fatherNotice.enabled = false;
        fatherDoing.enabled = false;
        snakeGame.enabled = false;
        StartCoroutine(Fail());
    }

    public GameObject successPage;
    IEnumerator Success()
    {
        yield return new WaitForSeconds(0.5f);
        successPage.SetActive(true);
    }
    public GameObject failedPage;
    public GameObject failHit;
    IEnumerator Fail()
    {
        failHit.SetActive(true);
        yield return new WaitForSeconds(3f);
        failedPage.SetActive(true);
    }
    public Score scoreText;
    public void AddScore(int add)
    {
        score += add;
        scoreText.AddScore(add);
    }
}
