using Unity.Mathematics;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset1 = new Vector3(0, 5, -6.74f);
    private Vector3 offset2 = new Vector3(0.25f, 1.98f, 0.61f);
    private bool thirdPerson = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            thirdPerson = !thirdPerson;
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //offset camera to be behind the car
        CameraSwitch();
    }

    void CameraSwitch()
    {
        if (thirdPerson)
        {
            transform.position = player.transform.position + offset1;
            transform.rotation = Quaternion.AngleAxis(21.513f, Vector3.right);
        }
        else
        {
            transform.position = player.transform.position + offset2;
            transform.rotation = Quaternion.AngleAxis(0, Vector3.right); 
        }
    }
}
