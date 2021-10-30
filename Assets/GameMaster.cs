using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameMaster : MonoBehaviour
{
    public GameObject blackScreen;
    public bool isPlaying = false;

    IEnumerator succCoro;
    IEnumerator failCoro;

    public float score = 0;
    private void Start()
    {
        blackScreen.SetActive(true);
        succCoro = Success();
        failCoro = Fail();
    }
    float playTime = 0;
    float playTimeAll = 0;
    void Update()
    {
        isPlaying = Input.GetKey(KeyCode.Space);
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
    public void Restart()
    {
        score = 0;
        playTime = 0;
        leftTime = 60;
        snakeGame.ReStart();
        fatherNotice.Restart();
        successPage.SetActive(false);
        failedPage.SetActive(false);
    }
    public void Succ()
    {
        StartCoroutine(succCoro);
    }
    public void Failed()
    {
        StartCoroutine(failCoro);
    }

    public GameObject successPage;
    IEnumerator Success()
    {
        yield return new WaitForSeconds(0.5f);
        successPage.SetActive(true);
    }
    public GameObject failedPage;
    IEnumerator Fail()
    {
        yield return new WaitForSeconds(0.5f);
        failedPage.SetActive(true);
    }
    public Score scoreText;
    public void AddScore(int add)
    {
        score += add;
        scoreText.AddScore(add);
    }
}
