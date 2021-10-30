using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleGenComponent : MonoBehaviour
{
    public float max_range = 100.0f;
    public float scale_per_second = 10.0f;
    public GameObject step;

    Vector3 init_scale;
    // Start is called before the first frame update
    void Start()
    {
        init_scale = Vector3.one * 1.75f;
    }

    // Update is called once per frame
    void Update()
    {
        step.transform.localScale += Vector3.one * Time.deltaTime * scale_per_second;
        if (step.transform.localScale.x > max_range)
        {
            step.transform.localScale = init_scale;
        }
    }
}
