using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    /*
    ACHTUNG / WARNING
    THIS IS WORK IN PROGRESS
    IT DOESN'T REPRESENT THE FINAL PRODUCT
    PLEASE DON'T LOOK AT THIS AS I REALLY JUST MADE IT IN A COUPLE SECONDS
    */

    private Keyboard kb;
    private Rigidbody rb;

    private bool wKeyPressed = false;
    private bool aKeyPressed = false;
    private bool sKeyPressed = false;
    private bool dKeyPressed = false;

    public float movementSpeed = 10f;

    private void Start()
    {
        kb = InputSystem.GetDevice<Keyboard>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (kb.wKey.isPressed)
        {
            wKeyPressed = true;
        }
        else
        {
            wKeyPressed = false;
        }

        if (kb.aKey.isPressed)
        {
            aKeyPressed = true;
        }
        else
        {
            aKeyPressed = false;
        }

        if (kb.sKey.isPressed)
        {
            sKeyPressed = true;
        }
        else
        {
            sKeyPressed = false;
        }

        if (kb.dKey.isPressed)
        {
            dKeyPressed = true;
        }
        else
        {
            dKeyPressed = false;
        }
    }

    private void FixedUpdate()
    {
        if (wKeyPressed)
        {
            rb.AddForce(movementSpeed * Time.fixedDeltaTime * Vector3.forward, ForceMode.VelocityChange);
        }
        if (aKeyPressed)
        {
            rb.AddForce(movementSpeed * Time.fixedDeltaTime * Vector3.left, ForceMode.VelocityChange);
        }
        if (sKeyPressed)
        {
            rb.AddForce(movementSpeed * Time.fixedDeltaTime * Vector3.back, ForceMode.VelocityChange);
        }
        if (dKeyPressed)
        {
            rb.AddForce(movementSpeed * Time.fixedDeltaTime * Vector3.right, ForceMode.VelocityChange);
        }
    }
}