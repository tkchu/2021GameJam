using UnityEngine;
using UnityEngine.UI;

public class TimeMono : MonoBehaviour
{
    GameMaster gameMaster;
    Text timeText;
    private void Awake()
    {
        gameMaster = FindObjectOfType<GameMaster>();
        timeText = GetComponent<Text>();
    }

    public void LateUpdate()
    {
        float time = gameMaster.leftTimeNow;
        int timeS = (int)time;
        int timeSS = (int)((time - timeS) * 100);
        timeText.text = string.Format("{0:00}:{1:00}", timeS, timeSS);
    }
}
