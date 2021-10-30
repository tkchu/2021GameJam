using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    GameMaster gameMaster;
    public Text scoreAddTextPrefab;

    Text scoreText;
    private void Awake()
    {
        gameMaster = FindObjectOfType<GameMaster>();
        scoreText = GetComponent<Text>();
    }
    public void LateUpdate()
    {
        scoreText.text = string.Format("{0:000000000}" , gameMaster.score);
    }
    public void AddScore(int add)
    {
        Text scoreAddText = Instantiate(scoreAddTextPrefab, transform);
        scoreAddText.text = "+" + add.ToString();
        scoreAddText.fontSize = 20 + add / 50;
        scoreAddText.gameObject.SetActive(true);
    }
}
