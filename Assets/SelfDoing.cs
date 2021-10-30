using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDoing : MonoBehaviour
{
    GameMaster gameMaster;
    TextMesh textMesh;
    void Start()
    {
        textMesh = GetComponent<TextMesh>();
        gameMaster = FindObjectOfType<GameMaster>();
    }

    private void Update()
    {
        if (gameMaster.isPlaying)
        {
            textMesh.text = "ÍæÍæÍæ";
        }
        else
        {
            textMesh.text = "¼Ù×°Ñ§Ï°ÖÐ";
        }
    }
}
