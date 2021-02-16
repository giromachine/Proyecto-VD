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
    bool pointingCamera;
    bool menuCamera = false;

    public Transform target;
    public Transform cameraPointing;
    public float speed = 15f;
    public Rigidbody rig;

    public GameObject canvasCameraMenu;

    public int zoom = 0;
    int initialZoom;

    void start()
    {
        initialZoom = zoom;
    }

    void Awake()
    {
        _control = new InputMaster();

        _control.Player.Interact.performed += ctx => InteractAction(ctx);
        _control.Player.LeftClick.performed += ctx => TakePhotoo(ctx);
        _control.Player.RightClick.performed += ctx => CameraAim(ctx);
        _control.Player.CameraMenu.performed += ctx => Menu(ctx);
        _control.Player.MiddleButton.performed += ctx => ZoomInOut(ctx);
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
        if (taken && !menuCamera)
        {
            screenShotHandler.GetComponent<ScreenShotHandler>().takeHiResShot = true;
        }
    }

    void ZoomInOut(InputAction.CallbackContext context)
    {
        
        if (taken && !menuCamera)
        {
            if (zoom <= 1)
            {
                zoom += 1;
            }
            else
            {
                zoom = initialZoom;
            }            
        }
    }

    void CameraAim(InputAction.CallbackContext context)
    {
        if (taken)
        {
            if (!pointingCamera)
            {
                pointingCamera = true;
            }
            else
            {
                pointingCamera = false;
            }
        }
    }

    void Menu(InputAction.CallbackContext context)
    {
        if (taken)
        {
            if (!menuCamera)
            {
                Debug.Log("Menu");
                menuCamera = true;
                canvasCameraMenu.SetActive(true);
            }
            else
            {
                Debug.Log("NoMenu");
                menuCamera = false;
                canvasCameraMenu.SetActive(false);
            }           
        }
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
            rig.useGravity = false;

            if (!pointingCamera)
            {
                this.transform.position = target.position;
                this.transform.rotation = target.rotation;
            }
            else
            {
                this.transform.position = cameraPointing.position;
                this.transform.rotation = cameraPointing.rotation;
            }
        }
    }
}
