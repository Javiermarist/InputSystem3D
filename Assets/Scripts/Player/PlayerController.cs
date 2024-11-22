using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float fuerzaSalto;
    [SerializeField] float velocidad;

    public PlayerInput playerInput;

    private Vector2 input;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();
    }

    void Update()
    {
        input = playerInput.actions["Move"].ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        rb.AddForce(new Vector3(input.x, 0, input.y) * velocidad);
    }

    public void Jump(InputAction.CallbackContext callbackContext)
    {
        if (callbackContext.performed)
        {
            rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
            Debug.Log("Jump");
        }
        Debug.Log(callbackContext.phase);
    }
}
