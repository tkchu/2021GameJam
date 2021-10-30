using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ScoreAddText : MonoBehaviour
{
    private void OnEnable()
    {
        transform.DOMoveY(150, 1f);
        StartCoroutine(End());
    }
    IEnumerator End()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
