using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject door;
    public GameObject center;
    public float open_door_speed = 100f;
    public float close_door_speed = 100f;
    public float angel;

    bool open_door = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (open_door)
        {
            door.transform.eulerAngles -= (Vector3.forward * Time.deltaTime * open_door_speed);
            if (door.transform.eulerAngles.z < -90f)
            {
                door.transform.eulerAngles = Vector3.zero;
            }
            else
            {
                door.transform.eulerAngles = Vector3.forward * -90f;
            }
        }
        else
        {
            if (door.transform.eulerAngles.z > 270)
            {
                door.transform.eulerAngles += (Vector3.forward * Time.deltaTime * close_door_speed);
                if (door.transform.eulerAngles.z > 0.0f)
                {
                    door.transform.eulerAngles = Vector3.forward * -90f;
                }
            }
            else
            {
                door.transform.eulerAngles = Vector3.zero;
            }
        }
        
    }
    
    public void open()
    {
        open_door = true;
    }

    public void close()
    {
        open_door = false;
    }
}
