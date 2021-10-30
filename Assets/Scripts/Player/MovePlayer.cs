using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public Transform born_pos;
    public Transform start_pos;
    public Transform end_pos;
    public float one_times = 5.0f;

    private Vector3 speed;
    private Vector3 s_p;
    private Vector3 e_p;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = born_pos.position;
        speed = (end_pos.position - start_pos.position) / one_times;
        s_p = start_pos.position;
        e_p = end_pos.position;
    }

    // Update is called once per frame
    void Update()
    {
        var position = transform.position + speed * Time.deltaTime;
        var offset = e_p - s_p;
        if (offset == Vector3.zero)
            return;
        var p2s = position - s_p;
        float t;
        if (offset.x != 0)
            t = p2s.x / offset.x;
        else if (offset.y != 0)
            t = p2s.y / offset.y;
        else if (offset.z != 0)
            t = p2s.z / offset.z;
        else
            return;
        if (t > 1 || t < 0)
            speed *= -1.0f;

        if (t > 1)
            position = e_p - (position - e_p);
        else if (t < 0)
            position = s_p + (s_p - position);

        transform.position = position;

        Debug.Log("t: " +  t + "position: " + position);
            
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            var p = Random.Range(0, 10);
            if (p > 5)
                collision.gameObject.GetComponent<MovePlayer>().speed *= -1.0f;
        }
    }
}
