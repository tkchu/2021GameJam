using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameMaster : MonoBehaviour
{
    public GameObject blackScreen;
    public bool isPlaying = false;
    public LineMono leftLine;
    public LineMono rightLine;
    public BlockCreater blockCreater;

    public bool leftDown;
    public bool leftKey;
    public bool rightDown;
    public bool rightKey;

    public float goodY = 10f+2.5f ;
    public float betterHit = 10-2.5f;
    public float offset = 5;

    AudioSource hit;
    private void Start()
    {
        //TODO
        //blackScreen.SetActive(true);
        hit = GetComponent<AudioSource>();
    }
    void Update()
    {
        isPlaying = Input.GetKey(KeyCode.Space);
        //TODO
        //blackScreen.SetActive(!isPlaying);
        leftDown = Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.F);
        rightDown = Input.GetKeyDown(KeyCode.Mouse1) || Input.GetKeyDown(KeyCode.J);
        leftKey = Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.F);
        rightKey = Input.GetKey(KeyCode.Mouse1) || Input.GetKey(KeyCode.J);

        if (leftDown)
        {
            leftLine.KeyDown();
            foreach(Block block in blockCreater.leftBlocks)
            {
                if (block)
                {
                    float hitY = Mathf.Abs(block.transform.position.y - leftLine.transform.position.y);
                    if (hitY <= goodY)
                    {
                        block.Hit();
                        SoundHit();
                    }
                }
            }
        }
        if (rightDown)
        {
            rightLine.KeyDown();
            foreach (Block block in blockCreater.rightBlocks)
            {
                if (block)
                {
                    float hitY = Mathf.Abs(block.transform.position.y - rightLine.transform.position.y);
                    if (hitY <= goodY)
                    {
                        block.Hit();
                        SoundHit();
                    }
                }
            }
        }
        leftLine.KeyHold(leftKey);
        rightLine.KeyHold(rightKey);
    }
    public void SoundHit()
    {
        hit.Play();
    }
}
