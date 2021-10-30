using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCreater : MonoBehaviour
{
    public Block leftBlock;
    public float[] timeCreateLeft =
    {
        0,1,2,3,4,5,6,7,8,9
    };
    public int leftIndex = 0;
    public List<Block> leftBlocks = new List<Block>();
    public List<Block> rightBlocks = new List<Block>();

    public Block rightBlock;
    public float[] timeCreateRight =
    {
        0,1,2,3,4,5,6,7,8,9
    };
    public int rightIndex = 0;


    public float timeNow = 0f;


    void Update()
    {
        timeNow += Time.deltaTime;
        for (int i = leftIndex ; i < timeCreateLeft.Length; i++)
        {
            if(timeNow>= timeCreateLeft[i])
            {
                leftBlocks.Add(CreateBlock(leftBlock));
                leftIndex += 1;
            }
        }

        for (int i = rightIndex; i < timeCreateRight.Length; i++)
        {
            if (timeNow >= timeCreateRight[i])
            {
                rightBlocks.Add(CreateBlock(rightBlock));
                rightIndex += 1;
            }
        }
    }
    public float speed = 200;
    public float acc = 200;
    public Block CreateBlock(Block block)
    {
        block.speed = speed;
        block.acc = acc;
        return Instantiate(block, transform);
    }
}
