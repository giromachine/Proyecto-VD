using System.Collections;
using System.Collections.Generic;
using ECM.Controllers;
using UnityEngine;
using UnityEngine.InputSystem;

public sealed class FirstPersonController : BaseFirstPersonController
{
    InputMaster _control;
    private bool onJump = false;
    
    public override void Awake() {

        // Initalize BaseFirstPersonController

            base.Awake();


        _control = new InputMaster();
        _control.Player.Jump.performed += ctx => Jump(ctx);
    }
    protected override void Animate()
        {
            // Add animator related code here...
        }

    protected override void HandleInput()
    {
        // Handle your custom input here...

        Vector2 direction = _control.Player.Move.ReadValue<Vector2>();

        moveDirection = new Vector3
        {
            x = direction.x,
            y = 0.0f,
            z = direction.y
        };

        jump = onJump;
        // Debug.Log(onJump);
        // Replace the above code with your custom input code
    }

    void Jump(InputAction.CallbackContext context) {
        onJump = context.ReadValueAsButton();
        Debug.Log(onJump);
    }

    private void OnEnable()
    {
        _control.Enable();
    }

    private void OnDisable()
    {
        _control.Disable();
    }

}
