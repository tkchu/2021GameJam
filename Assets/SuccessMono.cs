using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuccessMono : MonoBehaviour
{
    GameMaster gameMaster;
    public Text ruleText;

    void Awake()
    {
        gameMaster = FindObjectOfType<GameMaster>();
    }
    private void OnEnable()
    {
        ruleText.text = string.Format("��û�б����֣���ֱ�Ǹ��漣��\n ���յ÷֣�<color=\"red\" >{0}</color>",(int) gameMaster.scoreNow);
    }
}
