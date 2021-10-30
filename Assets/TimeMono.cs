using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeMono : MonoBehaviour
{
    Text text;
    public GameMaster gameMaster;
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = string.Format("{0:00}", gameMaster.leftTime);
    }
}
