using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCPlayer : MovePlayer
{
    CheckComponent checkComponent;
    // Start is called before the first frame update
    void Start()
    {
        checkComponent = GetComponent<CheckComponent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activeView(bool flag)
    {
        checkComponent.activeView(flag);
    }
}
