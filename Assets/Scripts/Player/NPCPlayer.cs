using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCPlayer : MovePlayer
{
    CheckComponent checkComponent;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        checkComponent = GetComponent<CheckComponent>();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    public void activeView(bool flag)
    {
        checkComponent.activeView(flag);
    }

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);
    }
}
