using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offsetBehindCar = new Vector3(0, 5, -8);
    private Vector3 offsetInCar = new Vector3(0, 2.18f, 1);
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = offsetBehindCar;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyUp(KeyCode.C))
        {
            offset = (offset == offsetBehindCar) ? offsetInCar : offsetBehindCar;
        }
        transform.position = player.transform.position + offset;
        if (offset == offsetInCar)
        {
            transform.rotation = player.transform.rotation;
        }
    }
}
