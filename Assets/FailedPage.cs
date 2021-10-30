using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailedPage : MonoBehaviour
{
    public Text scoreText;

    public GameMaster gameMaster;

    string[] items =
    {
        "竹尺",
        "拖鞋",
        "拖吧杆",
        "皮带",
        "扫帚",
        "拳头",
    };

    public GameObject restartText;

    int counter = 0;
    private void OnEnable()
    {
        counter += 1;
        if (counter < 5)
        {
            string item = items[Random.Range(0, items.Length)];
            scoreText.text = string.Format("你被发现了！\n然后被<color=\"red\">{0}</color>狠狠打了一顿", item);
        }else if(counter < 6)
        {
            scoreText.text = "你被发现了！\n你被男女混合双打了一顿，真是太惨了";
        }else if (counter < 7)
        {
            scoreText.text = "你被发现了！\n爸爸非常生气地踩碎了你的游戏机";
        }else if (counter < 8)
        {
            scoreText.text = "你被发现了！\n妈妈没有打你，只是哭，但你觉得比挨打更难受";
        }
        else 
        {
            scoreText.text = "你被发现了！\n不过，你已经长大了，爸妈不再干涉你了\n（游戏将在<color=\"red\">5</color>秒钟后自动关闭，去试试别的游戏吧！）";
            restartText.SetActive(false);
            StartCoroutine(LastFight());
        }
    }
    IEnumerator LastFight()
    {
        yield return new WaitForSeconds(1f);
        scoreText.text = "你被发现了！\n不过，你已经长大了，爸妈不再干涉你了\n（游戏将在<color=\"red\">4</color>秒钟后自动关闭，去试试别的游戏吧！）";
        yield return new WaitForSeconds(1f);
        scoreText.text = "你被发现了！\n不过，你已经长大了，爸妈不再干涉你了\n（游戏将在<color=\"red\">3</color>秒钟后自动关闭，去试试别的游戏吧！）";
        yield return new WaitForSeconds(1f);
        scoreText.text = "你被发现了！\n不过，你已经长大了，爸妈不再干涉你了\n（游戏将在<color=\"red\">2</color>秒钟后自动关闭，去试试别的游戏吧！）";
        yield return new WaitForSeconds(1f);
        scoreText.text = "你被发现了！\n不过，你已经长大了，爸妈不再干涉你了\n（游戏将在<color=\"red\">1</color>秒钟后自动关闭，去试试别的游戏吧！）";
        yield return new WaitForSeconds(1f);
        Application.Quit();
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            gameMaster.Restart();
        }
    }
}
