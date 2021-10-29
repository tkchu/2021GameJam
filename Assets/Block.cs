using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public float speed = 200;
    public float acc = 100;
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
        speed += acc * Time.deltaTime;

        if(transform.position.y < -1000)
        {
            Destroy(gameObject);
        }
    }

    public void Hit()
    {
        Destroy(gameObject);
    }
}
