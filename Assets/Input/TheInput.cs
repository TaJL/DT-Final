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
                }
            ]
        },
        {
            ""name"": ""Dialogue"",
            ""id"": ""0172185e-b6d5-4a1e-ba5a-6b1b5915ec80"",
            ""actions"": [
                {
                    ""name"": ""Next"",
                    ""type"": ""Button"",
                    ""id"": ""1debb61a-0c6b-401b-8940-d7220bdf9d77"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
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
                    ""id"": ""2c7d2275-9585-4588-9a85-9eeacd11bf9a"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6da7bd13-e27d-48a7-97f6-81b76870bd1b"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d2de351-f770-47b2-b3b0-92ff45e0d58b"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e523d3b-1583-4423-8241-503d2c53138b"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
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
        // WorldActions
        m_WorldActions = asset.FindActionMap("WorldActions", throwIfNotFound: true);
        m_WorldActions_Talk = m_WorldActions.FindAction("Talk", throwIfNotFound: true);
        // Dialogue
        m_Dialogue = asset.FindActionMap("Dialogue", throwIfNotFound: true);
        m_Dialogue_Next = m_Dialogue.FindAction("Next", throwIfNotFound: true);
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
    public struct DecissionActions
    {
        private @TheInput m_Wrapper;
        public DecissionActions(@TheInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @North => m_Wrapper.m_Decission_North;
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
            }
            m_Wrapper.m_DecissionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @North.started += instance.OnNorth;
                @North.performed += instance.OnNorth;
                @North.canceled += instance.OnNorth;
            }
        }
    }
    public DecissionActions @Decission => new DecissionActions(this);

    // WorldActions
    private readonly InputActionMap m_WorldActions;
    private IWorldActionsActions m_WorldActionsActionsCallbackInterface;
    private readonly InputAction m_WorldActions_Talk;
    public struct WorldActionsActions
    {
        private @TheInput m_Wrapper;
        public WorldActionsActions(@TheInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Talk => m_Wrapper.m_WorldActions_Talk;
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
            }
            m_Wrapper.m_WorldActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Talk.started += instance.OnTalk;
                @Talk.performed += instance.OnTalk;
                @Talk.canceled += instance.OnTalk;
            }
        }
    }
    public WorldActionsActions @WorldActions => new WorldActionsActions(this);

    // Dialogue
    private readonly InputActionMap m_Dialogue;
    private IDialogueActions m_DialogueActionsCallbackInterface;
    private readonly InputAction m_Dialogue_Next;
    private readonly InputAction m_Dialogue_Skip;
    public struct DialogueActions
    {
        private @TheInput m_Wrapper;
        public DialogueActions(@TheInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Next => m_Wrapper.m_Dialogue_Next;
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
                @Next.started -= m_Wrapper.m_DialogueActionsCallbackInterface.OnNext;
                @Next.performed -= m_Wrapper.m_DialogueActionsCallbackInterface.OnNext;
                @Next.canceled -= m_Wrapper.m_DialogueActionsCallbackInterface.OnNext;
                @Skip.started -= m_Wrapper.m_DialogueActionsCallbackInterface.OnSkip;
                @Skip.performed -= m_Wrapper.m_DialogueActionsCallbackInterface.OnSkip;
                @Skip.canceled -= m_Wrapper.m_DialogueActionsCallbackInterface.OnSkip;
            }
            m_Wrapper.m_DialogueActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Next.started += instance.OnNext;
                @Next.performed += instance.OnNext;
                @Next.canceled += instance.OnNext;
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
    }
    public interface IWorldActionsActions
    {
        void OnTalk(InputAction.CallbackContext context);
    }
    public interface IDialogueActions
    {
        void OnNext(InputAction.CallbackContext context);
        void OnSkip(InputAction.CallbackContext context);
    }
}
