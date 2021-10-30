using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotherDoing : MonoBehaviour
{
    TextMesh textMesh;
    void Start()
    {
        textMesh = GetComponent<TextMesh>();
        StartCoroutine(Dofood());
    }

    IEnumerator Dofood()
    {
        while (true)
        {
            textMesh.text = "做饭中";
            yield return new WaitForSeconds(1f);
            textMesh.text = "做饭中.";
            yield return new WaitForSeconds(1f);
            textMesh.text = "做饭中..";
            yield return new WaitForSeconds(1f);
            textMesh.text = "做饭中...";
            yield return new WaitForSeconds(1f);
        }
    }
}
