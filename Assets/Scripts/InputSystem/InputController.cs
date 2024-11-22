using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{
    public PlayerInput playerInput1;
    public PlayerInput playerInput2;

    void Start()
    {
        EnabledPlayerInput1();
        Debug.Log("Player2 disabled");
    }

    public void EnabledPlayerInput1()
    {
        if (playerInput1 != null && playerInput2 != null)
        {
            playerInput1.actions.FindActionMap("Player1").Enable();
            playerInput2.actions.FindActionMap("Player2").Disable();
        }
    }

    public void EnabledPlayerInput2()
    {
        if (playerInput1 != null && playerInput2 != null)
        {
            playerInput2.actions.FindActionMap("Player2").Enable();
            playerInput1.actions.FindActionMap("Player1").Disable();
        }
    }

}
