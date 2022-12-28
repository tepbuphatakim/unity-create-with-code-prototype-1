using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public enum PlayerControls { WASD, Arrows };
    public PlayerControls playerControl = PlayerControls.WASD;
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = getHorizontalInputValue(playerControl);
        forwardInput = getVerticalInputValue(playerControl);

        // Move the player (car) object
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }

    public int getVerticalInputValue(PlayerControls playerControl)
    {
        if (playerControl == PlayerControls.WASD)
        {
            if (Input.GetKey("w"))
            {
                return 1;
            }
            if (Input.GetKey("s"))
            {
                return -1;
            }
        }
        if (playerControl == PlayerControls.Arrows)
        {
            if (Input.GetKey("up"))
            {
                return 1;
            }
            if (Input.GetKey("down"))
            {
                return -1;
            }
        }
        return 0;
    }

    public int getHorizontalInputValue(PlayerControls playerControl)
    {
        if (playerControl == PlayerControls.WASD)
        {
            if (Input.GetKey("a"))
            {
                return -1;
            }
            if (Input.GetKey("d"))
            {
                return 1;
            }
        }
        if (playerControl == PlayerControls.Arrows)
        {
            if (Input.GetKey("left"))
            {
                return -1;
            }
            if (Input.GetKey("right"))
            {
                return 1;
            }
        }
        return 0;
    }
}
