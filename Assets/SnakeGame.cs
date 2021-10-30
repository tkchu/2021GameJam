using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Sirenix.OdinInspector;

public class SnakeGame : MonoBehaviour
{
    public List<Image> allBlock = new List<Image>();
    public int[,] all = new int[10, 20];
    public List<int> bodyX = new List<int>();
    public List<int> bodyY = new List<int>();
    [ShowInInspector]
    Vector2 heading = Vector2.down;

    public int appleX = 6;
    public int appleY = 10;
    private IEnumerator coroutine;
    public GameObject block;
    void ReStart()
    {
        gameOver = false;
        for (int i = 0; i < all.GetLength(0); i++)
        {
            for (int j = 0; j < all.GetLength(1); j++)
            {
                all[i, j] = 0;
            }
        }
        bodyX.Clear();
        bodyY.Clear();
        appleX = 6;
        appleY = 10;

        bodyX.Add(5);
        bodyY.Add(14);

        bodyX.Add(5);
        bodyY.Add(15);

        bodyX.Add(5);
        bodyY.Add(16);

        coroutine = GameOver();
        heading = Vector2.down;
        TimeNow = TimePreTick;
        mult = 1;
        score = 0;
    }
    void Tick()
    {
        int tempX = bodyX[0] + (int)heading.x;
        int tempY = bodyY[0] + (int)heading.y;
        if (tempX < 0 || tempX >= 10 || tempY < 0 || tempY >= 20)
        {
            StartCoroutine(coroutine);
            return;
        }
        for (int i = 0; i < bodyX.Count; i++)
        {
            if (tempX == bodyX[i] && tempY == bodyY[i])
            {
                StartCoroutine(coroutine);
                return;
            }
        }

        if(tempX == appleX && tempY == appleY)
        {
            Debug.Log("eatApple");
            bodyX.Insert(0, tempX);
            bodyY.Insert(0, tempY);
            CreateApple();
            return;
        }
        

        for (int i = bodyX.Count-1; i > 0; i--)
        {
            bodyX[i] = bodyX[i - 1];
        }
        for (int i = bodyY.Count - 1; i > 0; i--)
        {
            bodyY[i] = bodyY[i - 1];
        }
        bodyX[0] += (int)heading.x;
        bodyY[0] += (int)heading.y;

        Show();
    }
    public int mult = 1;
    public int score = 0;
    void CreateApple()
    {
        if(mult < 5)
        {
            mult += 1;
        }
        score += 1;

        List<int> okX = new List<int>();
        List<int> okY = new List<int>();
        
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                if(all[i,j] == 0)
                {
                    okX.Add(i);
                    okY.Add(j);
                }
            }
        }
        
        int t = Random.Range(0, okX.Count);

        appleX = okX[t];
        appleY = okY[t];
    }

    private void Start()
    {
        ReStart();
    }
    public float TimeNow = 0.3f;
    public float TimePreTick = 0.3f;
    float[] TimePreTicks = { 0.3f, 0.25f, 0.2f, 0.15f, 0.1f, 0.075f, 0.055f };
    private void Update()
    {
        if (gameOver)
        {
            return;
        }
        TimeNow -= Time.deltaTime;
        TimePreTick = TimePreTicks[mult];
        while(TimeNow <= 0)
        {
            TimeNow += TimePreTick;
            Tick();
        }

        int x = 0;int y = 0;
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            x -= 1;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            x += 1;
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            y -= 1;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            y += 1;
        }
        if (heading.x != 0)
        {
            if (y != 0)
            {
                heading = new Vector2(0, y);
            }
        }else if(heading.y != 0)
        {
            if (x != 0)
            {
                heading = new Vector2(x, 0);
            }
        }

    }

    public void Show()
    {
        //³õÊ¼»¯
        for (int i = 0; i < all.GetLength(0); i++)
        {
            for (int j = 0; j < all.GetLength(1); j++)
            {
                all[i, j] = 0;
            }
        }
        if (!hideAll)
        {
            //»­Éß
            for (int i = 0; i < bodyX.Count; i++)
            {
                all[bodyX[i], bodyY[i]] = 1;
            }
            //»­Æ»¹û
            all[appleX, appleY] = 1;
        }


        int counter = 0;
        foreach (int i in all)
        {
            if (i == 0)
            {
                allBlock[counter].color = new Color(1, 1, 1, 0.1f);
            }else if(i == 1)
            {
                allBlock[counter].color = new Color(1, 1, 1, 1f);
            }
            counter += 1;
        }
    }
    bool gameOver = false;
    bool hideAll = false;
    IEnumerator GameOver()
    {
        gameOver = true;
        hideAll = true;
        Show();
        yield return new WaitForSeconds(0.2f);
        hideAll = false;
        Show();
        yield return new WaitForSeconds(0.2f);
        hideAll = true;
        Show();
        yield return new WaitForSeconds(0.2f);
        hideAll = false;
        Show();
        yield return new WaitForSeconds(0.2f);
        hideAll = true;
        Show();
        yield return new WaitForSeconds(0.2f);
        hideAll = false;
        gameOver = false;
        ReStart();
    }
}
