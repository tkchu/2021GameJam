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
            textMesh.text = "������";
            yield return new WaitForSeconds(1f);
            textMesh.text = "������.";
            yield return new WaitForSeconds(1f);
            textMesh.text = "������..";
            yield return new WaitForSeconds(1f);
            textMesh.text = "������...";
            yield return new WaitForSeconds(1f);
        }
    }
}
