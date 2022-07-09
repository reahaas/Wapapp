using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public MovementJoystickController movementJoystickController;
    Rigidbody2D rb;

    float movementSpeed = 4f;

    public float runSpeed = 20.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if(movementJoystickController.joystickVec.y != 0)
        {
            rb.velocity = new Vector2(movementJoystickController.joystickVec.x * movementSpeed,
                movementJoystickController.joystickVec.y * movementSpeed);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }

    }
}