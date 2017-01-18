using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour
{
    public bool open;
    private AudioSource squeekSound;
    Transform Door;
    Transform LeftDoor;
    Transform RightDoor;

    NavMeshObstacle obstacle;
    public bool locked;
    public bool activated;

    // Use this for initialization
    void Start()
    {
        open = true;
        squeekSound = GetComponent<AudioSource>();
        if (this.transform.name == "SingleDoor")
        {
            Door = transform.FindChild("Door");
        }
        else if (this.transform.name == "DoubleDoor")
        {
            LeftDoor = transform.FindChild("LeftDoor");
            RightDoor = transform.FindChild("RightDoor");
        }
        obstacle = GetComponent<NavMeshObstacle>();
        locked = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (this.transform.name == "SingleDoor")
        {
            if (!open && Door.localRotation.y > 0)
            {
                Door.Rotate(0, -1, 0);
            }
            else if (!open && Door.localRotation.y < 0)
            {
                Door.localEulerAngles = new Vector3(Door.localEulerAngles.x, 0f, Door.localEulerAngles.z);
                locked = true;
                squeekSound.Stop();
            }
            if (open && Door.localRotation.y < 0.7)
            {
                Door.Rotate(0, 1, 0);
            }
            else if (open && Door.localRotation.y > 0.7)
            {
                Door.localEulerAngles = new Vector3(Door.localEulerAngles.x, 90f, Door.localEulerAngles.z);
                squeekSound.Stop();
            }
        }
        else if (this.transform.name == "DoubleDoor")
        {
            if (!open && LeftDoor.localRotation.y > 0)
            {
                LeftDoor.Rotate(0, -1, 0);
                RightDoor.Rotate(0, 1, 0);
            }
            else if (!open && LeftDoor.localRotation.y < 0)
            {
                LeftDoor.localEulerAngles = new Vector3(LeftDoor.localEulerAngles.x, 0f, LeftDoor.localEulerAngles.z);
                RightDoor.localEulerAngles = new Vector3(RightDoor.localEulerAngles.x, 0f, RightDoor.localEulerAngles.z);
                locked = true;
                squeekSound.Stop();
            }
            if (open && LeftDoor.localRotation.y < 0.7)
            {
                LeftDoor.Rotate(0, 1, 0);
                RightDoor.Rotate(0, -1, 0);
            }
            else if (open && LeftDoor.localRotation.y > 0.7)
            {
                LeftDoor.localEulerAngles = new Vector3(LeftDoor.localEulerAngles.x, 90f, LeftDoor.localEulerAngles.z);
                RightDoor.localEulerAngles = new Vector3(RightDoor.localEulerAngles.x, -90f, RightDoor.localEulerAngles.z);
                squeekSound.Stop();
            }

            if (open)
            {
                locked = false;
            }
            obstacle.enabled = locked;
        }
    }

    public void squeek()
    {
        squeekSound.Play();
    }
}