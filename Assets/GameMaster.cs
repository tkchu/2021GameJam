using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameMaster : MonoBehaviour
{
    public GameObject blackScreen;
    public bool isPlaying = false;

    private void Start()
    {
        //TODO
        //blackScreen.SetActive(true);
    }
    void Update()
    {
        isPlaying = Input.GetKey(KeyCode.Space);
        //TODO
        //blackScreen.SetActive(!isPlaying);
    }

}
