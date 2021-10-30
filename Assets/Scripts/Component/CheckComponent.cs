using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckComponent : MonoBehaviour
{
    public float anger_up_value = 10.0f;
    public GameObject target_unit;
    public GameObject view;

    // Start is called before the first frame update
    void Start()
    {
        activeView(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if (target_unit.isPlayGame())
        //    anger();
    }

    void anger()
    {
        //target_unit.health -= anger_up_value;
    }

    public void activeView(bool flag)
    {
        view.SetActive(flag);
    }
}
