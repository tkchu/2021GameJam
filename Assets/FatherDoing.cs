using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatherDoing : MonoBehaviour
{
    public Notice fatherNotice;
    public MeshRenderer reading;
    bool noticing = false;

    float timeToNotice = 10;
    float timeKeepNotice = 2;

    public GameMaster gameMaster;
    public void Restart()
    {
        noticing = false;
        timeToNotice = Random.Range(5f, 10f);
        timeKeepNotice = Random.Range(1f, 2f);
    }
    private void Start()
    {
        gameMaster = FindObjectOfType<GameMaster>();
    }
    void Update()
    {
        if (noticing)
        {
            if (gameMaster.isPlaying)
            {
                timeKeepNotice = 1f;
            }
            else
            {
                timeKeepNotice -= Time.deltaTime;
                if(timeKeepNotice <= 0 && fatherNotice.nowNotice<=0)
                {
                    noticing = false;
                    timeToNotice = Random.Range(5f, 10f);
                }
            }
        }
        else
        {
            timeToNotice -= Time.deltaTime;
            if (timeToNotice <= 0)
            {
                timeKeepNotice = Random.Range(1f, 2f);
                noticing = true;
            }
        }

        fatherNotice.isNoticing = noticing;
        if (noticing)
        {

            reading.GetComponent<TextMesh>().text = "<color=\"red\">¶¢×ÅÄã</color>";
        }
        else
        {
            reading.GetComponent<TextMesh>().text = "¿´±¨Ö½";
        }

    }
}
