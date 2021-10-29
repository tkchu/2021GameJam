using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    GameMaster gameMaster;
    public float scorePreSecond = 100;
    float scoreNow = 0;

    Text scoreText;
    private void Awake()
    {
        gameMaster = FindObjectOfType<GameMaster>();
        scoreText = GetComponent<Text>();
    }
    private void Update()
    {
        if (gameMaster.isPlaying)
        {
            scoreNow += scorePreSecond * Time.deltaTime;
        }
    }
    public void LateUpdate()
    {
        scoreText.text = string.Format("{0:000000000}" , scoreNow);
    }
}
