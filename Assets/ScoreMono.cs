using UnityEngine;
using UnityEngine.UI;

public class ScoreMono : MonoBehaviour
{
    GameMaster gameMaster;
    Text scoreText;
    private void Awake()
    {
        gameMaster = FindObjectOfType<GameMaster>();
        scoreText = GetComponent<Text>();
    }

    public void LateUpdate()
    {
        scoreText.text = string.Format("{0:000000000}" , gameMaster.scoreNow);
    }
}
