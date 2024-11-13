using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private float speed = 4f;
    private Vector2 moveInput;

    [SerializeField] private Transform cameraContainer;
    private float camxRot;
    private float xLook = 70f;
    private float sensitive = 0.1f;
    private Vector2 mouseDelta;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void FixedUpdate()
    {
        OnMove();
    }

    private void LateUpdate()
    {
        OnLook();
    }

    public void OnMoveInput(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            moveInput = context.ReadValue<Vector2>();
        }
        else if (context.phase == InputActionPhase.Canceled)
        {
            moveInput = Vector2.zero;
        }
    }

    public void OnLookInput(InputAction.CallbackContext context)
    {
        mouseDelta = context.ReadValue<Vector2>();
    }

    public void OnFireInput(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Started)
        {
            CharacterManager.Instance.Player.Weapon.Fire();
        }
    }

    public void OnMove()
    {
        Vector3 dir = transform.forward * moveInput.y + transform.right * moveInput.x;
        dir *= speed;
        dir.y = rb.velocity.y;

        rb.velocity = dir;
    }

    public void OnLook()
    {
        camxRot += mouseDelta.y * sensitive;
        camxRot = Mathf.Clamp(camxRot, -xLook, xLook);
        cameraContainer.localEulerAngles = new Vector3(-camxRot, 0, 0);
        transform.eulerAngles += new Vector3(0, mouseDelta.x * sensitive, 0);
    }
}
