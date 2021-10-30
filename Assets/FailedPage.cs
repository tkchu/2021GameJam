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
        "�ϰѸ�",
        "Ƥ��",
        "ɨ��",
        "��ë����",
        "ȭͷ",
    };

    public GameObject restartText;

    private void OnEnable()
    {
        int counter = PlayerPrefs.GetInt("failTimes", 0);
        counter += 1;
        PlayerPrefs.SetInt("failTimes", counter);
        if (counter < 2)
        {
            string item = items[Random.Range(0, items.Length)];
            scoreText.text = string.Format("�㱻<color=\"red\">�ְ�</color>�����ˣ�\nȻ��<color=\"red\">{0}</color>�ݺݴ���һ��", item);
        }else if(counter < 3)
        {
            scoreText.text = "�㱻<color=\"red\">�ְ�</color>�����ˣ�\n�㱻��Ů���˫����һ�٣�����̫����";
        }else if (counter < 4)
        {
            scoreText.text = "�㱻<color=\"red\">�ְ�</color>�����ˣ�\n�ְַǳ������ز����������Ϸ��";
        }else if (counter < 5)
        {
            scoreText.text = "�㱻<color=\"red\">�ְ�</color>�����ˣ�\n����û�д��㣬ֻ�ǿޣ�������ñȰ��������";
        }
        else 
        {
            scoreText.text = "�㱻<color=\"red\">�ְ�</color>�����ˣ�\n���������Ѿ������ˣ����費�ٴ�����";
                /*\n����Ϸ����<color=\"red\">5</color>���Ӻ��Զ��رգ�ȥ���Ա����Ϸ�ɣ���";
            restartText.SetActive(false);
            StartCoroutine(LastFight());
                */
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
            gameObject.SetActive(false);
            gameMaster.Restart();
        }
    }
}
