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
        "���",
        "��Ь",
        "�ϰɸ�",
        "Ƥ��",
        "ɨ��",
        "ȭͷ",
    };

    public GameObject restartText;

    int counter = 0;
    private void OnEnable()
    {
        counter += 1;
        if (counter < 5)
        {
            string item = items[Random.Range(0, items.Length)];
            scoreText.text = string.Format("�㱻�����ˣ�\nȻ��<color=\"red\">{0}</color>�ݺݴ���һ��", item);
        }else if(counter < 6)
        {
            scoreText.text = "�㱻�����ˣ�\n�㱻��Ů���˫����һ�٣�����̫����";
        }else if (counter < 7)
        {
            scoreText.text = "�㱻�����ˣ�\n�ְַǳ������ز����������Ϸ��";
        }else if (counter < 8)
        {
            scoreText.text = "�㱻�����ˣ�\n����û�д��㣬ֻ�ǿޣ�������ñȰ��������";
        }
        else 
        {
            scoreText.text = "�㱻�����ˣ�\n���������Ѿ������ˣ����費�ٸ�������\n����Ϸ����<color=\"red\">5</color>���Ӻ��Զ��رգ�ȥ���Ա����Ϸ�ɣ���";
            restartText.SetActive(false);
            StartCoroutine(LastFight());
        }
    }
    IEnumerator LastFight()
    {
        yield return new WaitForSeconds(1f);
        scoreText.text = "�㱻�����ˣ�\n���������Ѿ������ˣ����費�ٸ�������\n����Ϸ����<color=\"red\">4</color>���Ӻ��Զ��رգ�ȥ���Ա����Ϸ�ɣ���";
        yield return new WaitForSeconds(1f);
        scoreText.text = "�㱻�����ˣ�\n���������Ѿ������ˣ����費�ٸ�������\n����Ϸ����<color=\"red\">3</color>���Ӻ��Զ��رգ�ȥ���Ա����Ϸ�ɣ���";
        yield return new WaitForSeconds(1f);
        scoreText.text = "�㱻�����ˣ�\n���������Ѿ������ˣ����費�ٸ�������\n����Ϸ����<color=\"red\">2</color>���Ӻ��Զ��رգ�ȥ���Ա����Ϸ�ɣ���";
        yield return new WaitForSeconds(1f);
        scoreText.text = "�㱻�����ˣ�\n���������Ѿ������ˣ����費�ٸ�������\n����Ϸ����<color=\"red\">1</color>���Ӻ��Զ��رգ�ȥ���Ա����Ϸ�ɣ���";
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
