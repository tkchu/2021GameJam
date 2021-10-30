using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.SetInt("failTimes", 0);
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.Space)){
            SceneManager.LoadScene("main");
        }
    }
}
