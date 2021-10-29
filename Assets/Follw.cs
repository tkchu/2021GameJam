using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follw : MonoBehaviour
{
    public Transform followed;
    public Vector3 offset;

    private void Update()
    {
        transform.position = Camera.main.WorldToScreenPoint(followed.position + offset);
    }
}
