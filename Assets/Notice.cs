using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notice : MonoBehaviour
{
    public bool isNoticing = true;
    public float nowNotice = 0;

    public float addRate = 1;
    public float subRate = 0.5f;

    public Image fillImage;

    public GameMaster gameMaster;

    public void Restart()
    {
        nowNotice = 0;
    }
    void Update()
    {
        if (gameMaster.isPlaying && isNoticing)
        {
            nowNotice += addRate * Time.deltaTime;
        }
        else
        {
            nowNotice -= subRate * Time.deltaTime;
            if (nowNotice < 0)
            {
                nowNotice = 0;
            }
        }
        if (nowNotice >= 1f)
        {
            gameMaster.Failed();
        }
    }
    private void LateUpdate()
    {
        fillImage.fillAmount = nowNotice;
    }
}
