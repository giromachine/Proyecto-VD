// GENERATED AUTOMATICALLY FROM 'Assets/Control/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""ca4796fe-2531-42f4-9b15-cc42d03d4b83"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""7dea2a44-4c2a-41b8-a1b0-abe4c207c3cb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation X"",
                    ""type"": ""Value"",
                    ""id"": ""e3adb08e-1009-4702-9bf2-2031df7441f2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotation Y"",
                    ""type"": ""Value"",
                    ""id"": ""33ac0629-8ff4-4ba1-bec1-5bad183ba624"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""5200fa4a-2241-45fa-8893-f6785e5bfb0b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TakePhoto"",
                    ""type"": ""Button"",
                    ""id"": ""9403daa1-717f-4fbc-bcd3-d1144e73dbd5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""f82b5224-e5af-4b98-b703-29ce93920310"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""560f585d-e3c9-4d6a-81d6-639528e4af7e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y Ratón"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d8dd1c31-ee70-49ef-8362-b0a24d8154f6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y Ratón"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""407cb36d-751d-4877-99c8-e998cf07b4d2"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y Ratón"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ac3c850c-909d-48e9-bb04-eebdb5a503f2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y Ratón"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0f49dd6d-2b51-4dff-af7f-bf0db52bddcf"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y Ratón"",
                    ""action"": ""Rotation X"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6369c9c6-5f0f-4eec-99d3-3b9a68bff2fb"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y Ratón"",
                    ""action"": ""Rotation Y"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24e137c7-0cb2-44d1-a49b-0d355d1bcc1b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Teclado y Ratón"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3fa17b81-7e6b-4289-b805-ced2686dc2eb"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TakePhoto"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Teclado y Ratón"",
            ""bindingGroup"": ""Teclado y Ratón"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_RotationX = m_Player.FindAction("Rotation X", throwIfNotFound: true);
        m_Player_RotationY = m_Player.FindAction("Rotation Y", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_TakePhoto = m_Player.FindAction("TakePhoto", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_RotationX;
    private readonly InputAction m_Player_RotationY;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_TakePhoto;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @RotationX => m_Wrapper.m_Player_RotationX;
        public InputAction @RotationY => m_Wrapper.m_Player_RotationY;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @TakePhoto => m_Wrapper.m_Player_TakePhoto;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @RotationX.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotationX;
                @RotationX.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotationX;
                @RotationX.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotationX;
                @RotationY.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotationY;
                @RotationY.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotationY;
                @RotationY.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotationY;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @TakePhoto.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTakePhoto;
                @TakePhoto.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTakePhoto;
                @TakePhoto.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTakePhoto;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @RotationX.started += instance.OnRotationX;
                @RotationX.performed += instance.OnRotationX;
                @RotationX.canceled += instance.OnRotationX;
                @RotationY.started += instance.OnRotationY;
                @RotationY.performed += instance.OnRotationY;
                @RotationY.canceled += instance.OnRotationY;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @TakePhoto.started += instance.OnTakePhoto;
                @TakePhoto.performed += instance.OnTakePhoto;
                @TakePhoto.canceled += instance.OnTakePhoto;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_TecladoyRatónSchemeIndex = -1;
    public InputControlScheme TecladoyRatónScheme
    {
        get
        {
            if (m_TecladoyRatónSchemeIndex == -1) m_TecladoyRatónSchemeIndex = asset.FindControlSchemeIndex("Teclado y Ratón");
            return asset.controlSchemes[m_TecladoyRatónSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRotationX(InputAction.CallbackContext context);
        void OnRotationY(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnTakePhoto(InputAction.CallbackContext context);
    }
}
