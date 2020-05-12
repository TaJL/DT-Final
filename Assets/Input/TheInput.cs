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
                },
                {
                    ""name"": ""MeleeAttack"",
                    ""type"": ""Button"",
                    ""id"": ""d5cac941-e8a8-4107-b0dd-5bacf4ce41ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7cf5c2f1-2ddf-4f26-91ca-a238cdff0e65"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shield"",
                    ""type"": ""Button"",
                    ""id"": ""bbfa289e-b4ba-45cc-b769-ecfc9d710c4d"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""687648e9-7316-453b-a2fb-0908c46cbb65"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ba1b096-83f1-4d35-9c2c-2e7baa902283"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MeleeAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fbc5a4fc-cc82-4991-88a4-7f415ab5d5b6"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MeleeAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""keyboard"",
                    ""id"": ""690c3a8f-0d12-4b68-bf7b-385fc7897b81"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.5,y=0.5)"",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""729ea4c5-1f64-4209-b866-244b1c1e2fb6"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""87c51a19-c286-4d3f-a406-63a5e3bd56e8"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""88d83bc0-be7a-40e4-87b4-98a9feee97ef"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c0720a89-29d2-47c3-b41e-cf647e7d64bb"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6a8ade25-6824-47d7-84be-fc509d631d58"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7ce5f60-3fdb-4d89-98d2-2386a68e4443"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shield"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""567cda7d-1759-4db9-be19-dbaa2765cdf9"",
                    ""path"": ""<Keyboard>/slash"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shield"",
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
        },
        {
            ""name"": ""TitleScreen"",
            ""id"": ""85a4afb4-bdd7-46c4-8f0c-997f19e7f2c4"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""2699881a-db03-44d6-81bb-1be775992478"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""8e8b2157-ffe0-4613-a47d-8f0eae5add02"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""7f6b8a24-40fc-4924-b2ad-cef4644056cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b1eebf3c-46ec-4f14-a169-0caf176d5693"",
                    ""path"": ""<Keyboard>/#(W)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""171dc8a1-b957-424a-a6d2-d6f9b248f7ad"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be723e73-16f4-4710-93ff-acdd6d17effa"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d7a9aeb-8971-4a89-a9a1-f1a168db7e02"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""48e7892f-2939-44d2-b447-5c659759f6cd"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""10731684-9d36-4b9e-b68a-f972e76a53c9"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1e9f293-fa9e-4fb8-9f8b-33751d829e78"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9c05f505-ed59-456e-933b-e2445a2b790d"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Select"",
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
        m_WorldActions_MeleeAttack = m_WorldActions.FindAction("MeleeAttack", throwIfNotFound: true);
        m_WorldActions_Look = m_WorldActions.FindAction("Look", throwIfNotFound: true);
        m_WorldActions_Shield = m_WorldActions.FindAction("Shield", throwIfNotFound: true);
        // Dialogue
        m_Dialogue = asset.FindActionMap("Dialogue", throwIfNotFound: true);
        m_Dialogue_Skip = m_Dialogue.FindAction("Skip", throwIfNotFound: true);
        // TitleScreen
        m_TitleScreen = asset.FindActionMap("TitleScreen", throwIfNotFound: true);
        m_TitleScreen_Up = m_TitleScreen.FindAction("Up", throwIfNotFound: true);
        m_TitleScreen_Down = m_TitleScreen.FindAction("Down", throwIfNotFound: true);
        m_TitleScreen_Select = m_TitleScreen.FindAction("Select", throwIfNotFound: true);
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
    private readonly InputAction m_WorldActions_MeleeAttack;
    private readonly InputAction m_WorldActions_Look;
    private readonly InputAction m_WorldActions_Shield;
    public struct WorldActionsActions
    {
        private @TheInput m_Wrapper;
        public WorldActionsActions(@TheInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Talk => m_Wrapper.m_WorldActions_Talk;
        public InputAction @Move => m_Wrapper.m_WorldActions_Move;
        public InputAction @MeleeAttack => m_Wrapper.m_WorldActions_MeleeAttack;
        public InputAction @Look => m_Wrapper.m_WorldActions_Look;
        public InputAction @Shield => m_Wrapper.m_WorldActions_Shield;
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
                @MeleeAttack.started -= m_Wrapper.m_WorldActionsActionsCallbackInterface.OnMeleeAttack;
                @MeleeAttack.performed -= m_Wrapper.m_WorldActionsActionsCallbackInterface.OnMeleeAttack;
                @MeleeAttack.canceled -= m_Wrapper.m_WorldActionsActionsCallbackInterface.OnMeleeAttack;
                @Look.started -= m_Wrapper.m_WorldActionsActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_WorldActionsActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_WorldActionsActionsCallbackInterface.OnLook;
                @Shield.started -= m_Wrapper.m_WorldActionsActionsCallbackInterface.OnShield;
                @Shield.performed -= m_Wrapper.m_WorldActionsActionsCallbackInterface.OnShield;
                @Shield.canceled -= m_Wrapper.m_WorldActionsActionsCallbackInterface.OnShield;
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
                @MeleeAttack.started += instance.OnMeleeAttack;
                @MeleeAttack.performed += instance.OnMeleeAttack;
                @MeleeAttack.canceled += instance.OnMeleeAttack;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Shield.started += instance.OnShield;
                @Shield.performed += instance.OnShield;
                @Shield.canceled += instance.OnShield;
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

    // TitleScreen
    private readonly InputActionMap m_TitleScreen;
    private ITitleScreenActions m_TitleScreenActionsCallbackInterface;
    private readonly InputAction m_TitleScreen_Up;
    private readonly InputAction m_TitleScreen_Down;
    private readonly InputAction m_TitleScreen_Select;
    public struct TitleScreenActions
    {
        private @TheInput m_Wrapper;
        public TitleScreenActions(@TheInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_TitleScreen_Up;
        public InputAction @Down => m_Wrapper.m_TitleScreen_Down;
        public InputAction @Select => m_Wrapper.m_TitleScreen_Select;
        public InputActionMap Get() { return m_Wrapper.m_TitleScreen; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TitleScreenActions set) { return set.Get(); }
        public void SetCallbacks(ITitleScreenActions instance)
        {
            if (m_Wrapper.m_TitleScreenActionsCallbackInterface != null)
            {
                @Up.started -= m_Wrapper.m_TitleScreenActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_TitleScreenActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_TitleScreenActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_TitleScreenActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_TitleScreenActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_TitleScreenActionsCallbackInterface.OnDown;
                @Select.started -= m_Wrapper.m_TitleScreenActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_TitleScreenActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_TitleScreenActionsCallbackInterface.OnSelect;
            }
            m_Wrapper.m_TitleScreenActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
            }
        }
    }
    public TitleScreenActions @TitleScreen => new TitleScreenActions(this);
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
        void OnMeleeAttack(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnShield(InputAction.CallbackContext context);
    }
    public interface IDialogueActions
    {
        void OnSkip(InputAction.CallbackContext context);
    }
    public interface ITitleScreenActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
    }
}
