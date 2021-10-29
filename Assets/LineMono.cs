using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineMono : MonoBehaviour
{
    Image image;
    public Color normal;
    public Color high = Color.red;
    
    private void Awake()
    {
        image = GetComponent<Image>();
        normal = image.color;
    }
    public void KeyDown()
    {
        
    }

    public void KeyHold(bool leftKey)
    {
        image.color = leftKey ? high : normal;
    }
}
