using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleGenComponent : MonoBehaviour
{
    public float max_range = 100.0f;
    public float scale_per_second = 100f;
    public float circle_born_t = 1.0f;
    public Transform circle;
    Transform[] circles = { };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ArrayList delete_circles = new ArrayList();
        ArrayList continue_circles = new ArrayList();

        foreach(var circle_go in circles)
        {
            circle_go.transform.localScale += Vector3.one * Time.deltaTime * scale_per_second;
            if (circle_go.transform.localScale.x >= (Vector3.one * max_range).x)
            {
                delete_circles.Add(circle_go);
                circle_go.gameObject.SetActive(false);
                Destroy(circle_go.gameObject);
            }
            else
                continue_circles.Add(circle_go);
        }
        if (Mathf.CeilToInt(Time.time * 10) % Mathf.CeilToInt(circle_born_t * 10) == 0)
        {
            continue_circles.Add(Instantiate(circle, Vector3.one, Quaternion.identity));
        }
        circles = (Transform[])continue_circles.ToArray(typeof(Transform));
    }
}
