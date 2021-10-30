using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : MonoBehaviour
{

    float t=0;
    void Update()
    {
        t += Time.deltaTime;
        if (t > 0.25f)
        {
            foreach (Transform t in transform)
            {
                t.gameObject.SetActive(false);
            }
        }
        if (t > 0.5f)
        {
            foreach (Transform t in transform)
            {
                t.gameObject.SetActive(true);
            }
            t = 0f;
        }
    }
}
