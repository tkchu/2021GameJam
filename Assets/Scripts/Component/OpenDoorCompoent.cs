using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorCompoent : MonoBehaviour
{
    public DoorController door;
    public float open_posiblity = 0.5f;
    NPCPlayer hold;
    // Start is called before the first frame update
    void Start()
    {
        hold = GetComponent<NPCPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "OpenDoorArea")
        {
            tryOpenDoor();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "OpenDoorArea")
        {
            door.close();
        }
    }

    void tryOpenDoor() 
    {
        var p = Random.Range(0, 10) / 10.0f;
        if (p <= open_posiblity)
        {
            door.open();
            //hold.activeView(true);
        }
    }
}
