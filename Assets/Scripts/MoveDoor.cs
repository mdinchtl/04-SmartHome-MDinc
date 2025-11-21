using UnityEngine;

public class DoorOpener : MonoBehaviour
{

    public Transform door1;
    public Transform door2;
    public Transform door3;


    public float openAngle = 90f;
    public float speed = 3f;

    bool isOpening1 = false;
    bool isOpening2 = false;
    bool isOpening3 = false;

    Quaternion targetRot1;
    Quaternion targetRot2;
    Quaternion targetRot3;

    void Update()
    {
        if (isOpening1 && door1 != null)
            door1.localRotation = Quaternion.Lerp(door1.localRotation, targetRot1, Time.deltaTime * speed);

        if (isOpening2 && door2 != null)
            door2.localRotation = Quaternion.Lerp(door2.localRotation, targetRot2, Time.deltaTime * speed);

        if (isOpening3 && door3 != null)
            door3.localRotation = Quaternion.Lerp(door3.localRotation, targetRot3, Time.deltaTime * speed);
    }

    public void OpenDoor(int index)
    {
        switch (index)
        {
            case 1:
                if (door1 != null)
                {
                    targetRot1 = Quaternion.Euler(0, openAngle, 0);
                    isOpening1 = true;
                }
                break;

            case 2:
                if (door2 != null)
                {
                    targetRot2 = Quaternion.Euler(0, openAngle, 0);
                    isOpening2 = true;
                }
                break;

            case 3:
                if (door3 != null)
                {
                    targetRot3 = Quaternion.Euler(0, openAngle, 0);
                    isOpening3 = true;
                }
                break;
        }
    }
}
