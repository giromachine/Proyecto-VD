using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PhotographicCamera : MonoBehaviour
{
    InputMaster _control;

    public GameObject screenShotHandler;

    bool detected;
    bool taken;

    public Transform target;
    public float speed = 15f;
    public Rigidbody rig;

    void Awake()
    {
        _control = new InputMaster();

        _control.Player.Interact.performed += ctx => InteractAction(ctx);
        _control.Player.LeftClick.performed += ctx => TakePhotoo(ctx);
        _control.Player.RightClick.performed += ctx => CameraAim(ctx);
        _control.Player.CameraMenu.performed += ctx => Menu(ctx);
    }

    private void OnEnable()
    {
        _control.Enable();
    }

    private void OnDisable()
    {
        _control.Disable();
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
        Debug.Log("TakePhoto");

        //if (taken)
        //{
            //screenShotHandler.GetComponent<ScreenShotHandler>().takeHiResShot = true;
        //}
    }

    void CameraAim(InputAction.CallbackContext context)
    {
        Debug.Log("CameraAim");
    }

    void Menu(InputAction.CallbackContext context)
    {
        Debug.Log("Menu");
    }

    void Detection()
    {
        detected = true;
    }

    void NoDetection()
    {
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
