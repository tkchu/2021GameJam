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
        ruleText.text = string.Format("你没有被发现，简直是个奇迹！\n 最终得分：<color=\"red\" >{0}</color>",(int) gameMaster.scoreNow);
    }
}
