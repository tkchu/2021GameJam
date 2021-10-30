using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatherDoing : MonoBehaviour
{
    public Notice fatherNotice;
    public MeshRenderer reading;
    bool noticing = false;

    void Update()
    {
        fatherNotice.isNoticing = noticing;
        reading.enabled = !noticing;
    }
}
