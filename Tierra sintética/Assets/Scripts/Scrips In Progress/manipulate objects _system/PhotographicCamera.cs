using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PhotographicCamera : MonoBehaviour
{
    InputMaster _controls;

    public GameObject screenShotHandler;

    bool detected;
    bool taken;

    public Transform target;
    public float speed = 15f;
    public Rigidbody rig;

    void Awake()
    {
        _controls = new InputMaster();

        _controls.Player.Interact.performed += ctx => InteractAction(ctx);
        _controls.Player.LeftClick.performed += ctx => TakePhotoo(ctx);
        _controls.Player.RightClick.performed += ctx => CameraAim(ctx);
        _controls.Player.CameraMenu.performed += ctx => Menu(ctx);
    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }


    void InteractAction(InputAction.CallbackContext context)
    {
        if (detected)
        {
            if (!taken)
            {
                taken = true;
            }
            else
            {
                taken = false;
                rig.useGravity = true;
            }
        }
    }

    void TakePhotoo(InputAction.CallbackContext context)
    {
        if (taken)
        {
            screenShotHandler.GetComponent<ScreenShotHandler>().takeHiResShot = true;
        }
    }

    void CameraAim(InputAction.CallbackContext context)
    {

    }

    void Menu(InputAction.CallbackContext context)
    {

    }

    void Detection()
    {
        Debug.Log("detection");

        detected = true;
    }

    void NoDetection()
    {
        Debug.Log("no detection");

        detected = false;

        if (taken)
        {
            taken = false;
            rig.useGravity = true;
        }
    }

    private void Update()
    {
        if (taken)
        {
            this.transform.position = target.position;
            this.transform.rotation = target.rotation;
            rig.useGravity = false;
        }
    }
}
