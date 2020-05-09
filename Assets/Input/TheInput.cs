// GENERATED AUTOMATICALLY FROM 'Assets/Input/TheInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @TheInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @TheInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TheInput"",
    ""maps"": [
        {
            ""name"": ""Decission"",
            ""id"": ""80bca150-0257-4702-8dd7-3e7e61b831e3"",
            ""actions"": [
                {
                    ""name"": ""North"",
                    ""type"": ""Button"",
                    ""id"": ""df929382-4f3d-4b3e-afe5-9583f2078beb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""East"",
                    ""type"": ""Button"",
                    ""id"": ""f23609ea-1f24-4141-9821-973ad9542e07"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""South"",
                    ""type"": ""Button"",
                    ""id"": ""1be8a542-172d-4369-b9f7-e5072a7d39e2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""West"",
                    ""type"": ""Button"",
                    ""id"": ""1c3f7008-af3e-4f34-9fc9-3e83c00b2757"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b775a9e5-360f-4c53-af32-340778f2d169"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""North"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f9ff09f7-702c-4f9d-9471-f240b9d0abcc"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""North"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a5b423e-87e5-4692-b466-e3504acb5577"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""East"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7aa82e50-e749-48d6-95f5-8921e4f95f5b"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""East"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78332c2c-355d-4dd3-bdc0-2e9b5f05cce8"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""South"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e8795d2-84b5-483d-91fd-c6a9abb36c99"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""South"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ca69348-c115-4ac3-94d6-4d5aa1a9efec"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""West"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4cd8a2fa-efa9-4c9a-9337-8438373f4aaf"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""West"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""WorldActions"",
            ""id"": ""19815402-4883-4b42-bde7-2e964f214c31"",
            ""actions"": [
                {
                    ""name"": ""Talk"",
                    ""type"": ""Button"",
                    ""id"": ""9f3cf2cf-b49d-4aec-bc36-0131ecb34c91"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""27f26772-cd9d-4dcf-b418-7e596e5113d5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a0f30089-ce15-4b93-8d38-d563e23d546e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Talk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9d694f8-1104-4c14-8a62-cde0e7de5a20"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Talk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""82de41cd-3beb-4168-add1-322837e68b11"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""755db05d-c984-4259-b45b-bc49f90104a6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8654345c-0f9d-4cd9-9760-6f3946bd813e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f824c103-14b3-4318-a8bc-739e7c95879e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b99444c0-1aae-4ca2-9af3-ad5a11cdbb92"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""48c08b1b-43ec-46e7-a364-8d9f9101c903"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Dialogue"",
            ""id"": ""0172185e-b6d5-4a1e-ba5a-6b1b5915ec80"",
            ""actions"": [
                {
                    ""name"": ""Skip"",
                    ""type"": ""Button"",
                    ""id"": ""12d8b8d5-7478-4660-af51-4c5ceb26f1de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ee2bd809-f44c-4615-b640-0be4fefd89ae"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67162a1a-45ce-4cfe-876d-423b8576b6e8"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Decission
        m_Decission = asset.FindActionMap("Decission", throwIfNotFound: true);
        m_Decission_North = m_Decission.FindAction("North", throwIfNotFound: true);
        m_Decission_East = m_Decission.FindAction("East", throwIfNotFound: true);
        m_Decission_South = m_Decission.FindAction("South", throwIfNotFound: true);
        m_Decission_West = m_Decission.FindAction("West", throwIfNotFound: true);
        // WorldActions
        m_WorldActions = asset.FindActionMap("WorldActions", throwIfNotFound: true);
        m_WorldActions_Talk = m_WorldActions.FindAction("Talk", throwIfNotFound: true);
        m_WorldActions_Move = m_WorldActions.FindAction("Move", throwIfNotFound: true);
        // Dialogue
        m_Dialogue = asset.FindActionMap("Dialogue", throwIfNotFound: true);
        m_Dialogue_Skip = m_Dialogue.FindAction("Skip", throwIfNotFound: true);
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

    // Decission
    private readonly InputActionMap m_Decission;
    private IDecissionActions m_DecissionActionsCallbackInterface;
    private readonly InputAction m_Decission_North;
    private readonly InputAction m_Decission_East;
    private readonly InputAction m_Decission_South;
    private readonly InputAction m_Decission_West;
    public struct DecissionActions
    {
        private @TheInput m_Wrapper;
        public DecissionActions(@TheInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @North => m_Wrapper.m_Decission_North;
        public InputAction @East => m_Wrapper.m_Decission_East;
        public InputAction @South => m_Wrapper.m_Decission_South;
        public InputAction @West => m_Wrapper.m_Decission_West;
        public InputActionMap Get() { return m_Wrapper.m_Decission; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DecissionActions set) { return set.Get(); }
        public void SetCallbacks(IDecissionActions instance)
        {
            if (m_Wrapper.m_DecissionActionsCallbackInterface != null)
            {
                @North.started -= m_Wrapper.m_DecissionActionsCallbackInterface.OnNorth;
                @North.performed -= m_Wrapper.m_DecissionActionsCallbackInterface.OnNorth;
                @North.canceled -= m_Wrapper.m_DecissionActionsCallbackInterface.OnNorth;
                @East.started -= m_Wrapper.m_DecissionActionsCallbackInterface.OnEast;
                @East.performed -= m_Wrapper.m_DecissionActionsCallbackInterface.OnEast;
                @East.canceled -= m_Wrapper.m_DecissionActionsCallbackInterface.OnEast;
                @South.started -= m_Wrapper.m_DecissionActionsCallbackInterface.OnSouth;
                @South.performed -= m_Wrapper.m_DecissionActionsCallbackInterface.OnSouth;
                @South.canceled -= m_Wrapper.m_DecissionActionsCallbackInterface.OnSouth;
                @West.started -= m_Wrapper.m_DecissionActionsCallbackInterface.OnWest;
                @West.performed -= m_Wrapper.m_DecissionActionsCallbackInterface.OnWest;
                @West.canceled -= m_Wrapper.m_DecissionActionsCallbackInterface.OnWest;
            }
            m_Wrapper.m_DecissionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @North.started += instance.OnNorth;
                @North.performed += instance.OnNorth;
                @North.canceled += instance.OnNorth;
                @East.started += instance.OnEast;
                @East.performed += instance.OnEast;
                @East.canceled += instance.OnEast;
                @South.started += instance.OnSouth;
                @South.performed += instance.OnSouth;
                @South.canceled += instance.OnSouth;
                @West.started += instance.OnWest;
                @West.performed += instance.OnWest;
                @West.canceled += instance.OnWest;
            }
        }
    }
    public DecissionActions @Decission => new DecissionActions(this);

    // WorldActions
    private readonly InputActionMap m_WorldActions;
    private IWorldActionsActions m_WorldActionsActionsCallbackInterface;
    private readonly InputAction m_WorldActions_Talk;
    private readonly InputAction m_WorldActions_Move;
    public struct WorldActionsActions
    {
        private @TheInput m_Wrapper;
        public WorldActionsActions(@TheInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Talk => m_Wrapper.m_WorldActions_Talk;
        public InputAction @Move => m_Wrapper.m_WorldActions_Move;
        public InputActionMap Get() { return m_Wrapper.m_WorldActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WorldActionsActions set) { return set.Get(); }
        public void SetCallbacks(IWorldActionsActions instance)
        {
            if (m_Wrapper.m_WorldActionsActionsCallbackInterface != null)
            {
                @Talk.started -= m_Wrapper.m_WorldActionsActionsCallbackInterface.OnTalk;
                @Talk.performed -= m_Wrapper.m_WorldActionsActionsCallbackInterface.OnTalk;
                @Talk.canceled -= m_Wrapper.m_WorldActionsActionsCallbackInterface.OnTalk;
                @Move.started -= m_Wrapper.m_WorldActionsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_WorldActionsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_WorldActionsActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_WorldActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Talk.started += instance.OnTalk;
                @Talk.performed += instance.OnTalk;
                @Talk.canceled += instance.OnTalk;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public WorldActionsActions @WorldActions => new WorldActionsActions(this);

    // Dialogue
    private readonly InputActionMap m_Dialogue;
    private IDialogueActions m_DialogueActionsCallbackInterface;
    private readonly InputAction m_Dialogue_Skip;
    public struct DialogueActions
    {
        private @TheInput m_Wrapper;
        public DialogueActions(@TheInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Skip => m_Wrapper.m_Dialogue_Skip;
        public InputActionMap Get() { return m_Wrapper.m_Dialogue; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DialogueActions set) { return set.Get(); }
        public void SetCallbacks(IDialogueActions instance)
        {
            if (m_Wrapper.m_DialogueActionsCallbackInterface != null)
            {
                @Skip.started -= m_Wrapper.m_DialogueActionsCallbackInterface.OnSkip;
                @Skip.performed -= m_Wrapper.m_DialogueActionsCallbackInterface.OnSkip;
                @Skip.canceled -= m_Wrapper.m_DialogueActionsCallbackInterface.OnSkip;
            }
            m_Wrapper.m_DialogueActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Skip.started += instance.OnSkip;
                @Skip.performed += instance.OnSkip;
                @Skip.canceled += instance.OnSkip;
            }
        }
    }
    public DialogueActions @Dialogue => new DialogueActions(this);
    public interface IDecissionActions
    {
        void OnNorth(InputAction.CallbackContext context);
        void OnEast(InputAction.CallbackContext context);
        void OnSouth(InputAction.CallbackContext context);
        void OnWest(InputAction.CallbackContext context);
    }
    public interface IWorldActionsActions
    {
        void OnTalk(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IDialogueActions
    {
        void OnSkip(InputAction.CallbackContext context);
    }
}
