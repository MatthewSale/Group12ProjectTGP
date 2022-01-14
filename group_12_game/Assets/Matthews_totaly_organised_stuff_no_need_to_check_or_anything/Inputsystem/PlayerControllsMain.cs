// GENERATED AUTOMATICALLY FROM 'Assets/Matthews_totaly_organised_stuff_no_need_to_check_or_anything/Inputsystem/PlayerControllsMain.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControllsMain : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControllsMain()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControllsMain"",
    ""maps"": [
        {
            ""name"": ""GamePlay"",
            ""id"": ""bbc32531-724c-4216-8520-30542c053415"",
            ""actions"": [
                {
                    ""name"": ""ForwardMovement"",
                    ""type"": ""Button"",
                    ""id"": ""968b0a16-08f8-4d70-9da3-fa48027f19b0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftMovement"",
                    ""type"": ""Button"",
                    ""id"": ""680672d3-815b-419d-bbc1-26f0d54b7827"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightMovement"",
                    ""type"": ""Button"",
                    ""id"": ""f39b664e-3683-4f5c-b8ad-8e5fb07c8a87"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BackMovement"",
                    ""type"": ""Button"",
                    ""id"": ""97a97054-8417-41ff-9590-b0016c9c9ef3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6388d54e-0703-49ed-95c8-dfa89b66a6d8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40e5d87b-7335-426f-8662-ef6a762b2084"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1319b74c-69c3-43f3-a6da-4f7aa5ddd755"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5647da5-6c2f-4247-b03a-17a463298cc1"",
                    ""path"": ""<Keyboard>/numpad8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8fe37a5d-5a20-486a-aa45-cf940d7da6b4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0692ce07-1275-4d93-8016-7d3c6b90c7ca"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ddb2995-5803-4657-859c-541f58f9ad2c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b7d6a635-43f0-4eca-903c-cdb1ad9be2ed"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1bd052dc-5a2d-4861-8407-413fff7d14f1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5d7b113-2194-4218-a64e-bb83e41ea593"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""796f4367-2847-45d1-9b11-fae7e0617fef"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""08958a21-f3a4-40a0-9686-d5f9d8400220"",
                    ""path"": ""<Keyboard>/numpad6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b8cafc2-970f-43dd-8f10-d08272119cb9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b0e6e041-cff9-4698-8eaa-692fc2c115ff"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b9104e60-ee08-4ccf-b184-7a7d19d8c3e0"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c62aeed-893a-4948-bad1-6fb08480ab56"",
                    ""path"": ""<Keyboard>/numpad2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""main player controlls1"",
            ""id"": ""1fed18c9-5eac-4ed8-91fb-e1b988d98ab7"",
            ""actions"": [
                {
                    ""name"": ""ForwardMovement"",
                    ""type"": ""Button"",
                    ""id"": ""1e0cf6cb-9253-444a-a3a5-25f5a85fbd7d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftMovement"",
                    ""type"": ""Button"",
                    ""id"": ""e8b28125-9212-418d-b269-ba1c064996e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightMovement"",
                    ""type"": ""Button"",
                    ""id"": ""25136e94-0ad6-45d8-bba9-cb2b01233dc3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BackMovement"",
                    ""type"": ""Button"",
                    ""id"": ""38853c14-6898-4190-8bbc-1b4301743e14"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0619de74-bbd4-4a4c-bca8-7c9b0b4a0696"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dcba829e-6f59-4865-8a58-9c59ab530d45"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e270ca5-1720-48fe-b6be-e8372b1da1e0"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f0bf488-c95a-4063-9035-895d8a9ca18c"",
                    ""path"": ""<Keyboard>/numpad8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForwardMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d883224c-1c7e-425d-bec1-eb264bd268e5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1db0a0ba-fa4e-4fc3-bda7-7738f8ad4aef"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02166a43-e3ce-418c-95c4-c13e940b3599"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b9fc577-490c-49fa-86c1-87b8520db5b5"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b1603f2c-1b01-4306-b7e7-aab624969126"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd03abf1-9d12-4798-bbcb-b1c1c4e3210c"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ead50b2d-39bc-47e3-be1d-a650404abf1f"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4eaf66ee-abc5-4a4f-8ff0-8f2efd9e6c67"",
                    ""path"": ""<Keyboard>/numpad2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""18b098b9-a39d-4a3b-892f-7f90c9e2b93d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""186d5cf0-9290-439e-84d3-19cc3910d37a"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6880502-f2f2-46bd-88f7-be8c330428eb"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea23c96b-b56a-4b22-ab7e-61c25f5d02bb"",
                    ""path"": ""<Keyboard>/numpad6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GamePlay
        m_GamePlay = asset.FindActionMap("GamePlay", throwIfNotFound: true);
        m_GamePlay_ForwardMovement = m_GamePlay.FindAction("ForwardMovement", throwIfNotFound: true);
        m_GamePlay_LeftMovement = m_GamePlay.FindAction("LeftMovement", throwIfNotFound: true);
        m_GamePlay_RightMovement = m_GamePlay.FindAction("RightMovement", throwIfNotFound: true);
        m_GamePlay_BackMovement = m_GamePlay.FindAction("BackMovement", throwIfNotFound: true);
        // main player controlls1
        m_mainplayercontrolls1 = asset.FindActionMap("main player controlls1", throwIfNotFound: true);
        m_mainplayercontrolls1_ForwardMovement = m_mainplayercontrolls1.FindAction("ForwardMovement", throwIfNotFound: true);
        m_mainplayercontrolls1_LeftMovement = m_mainplayercontrolls1.FindAction("LeftMovement", throwIfNotFound: true);
        m_mainplayercontrolls1_RightMovement = m_mainplayercontrolls1.FindAction("RightMovement", throwIfNotFound: true);
        m_mainplayercontrolls1_BackMovement = m_mainplayercontrolls1.FindAction("BackMovement", throwIfNotFound: true);
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

    // GamePlay
    private readonly InputActionMap m_GamePlay;
    private IGamePlayActions m_GamePlayActionsCallbackInterface;
    private readonly InputAction m_GamePlay_ForwardMovement;
    private readonly InputAction m_GamePlay_LeftMovement;
    private readonly InputAction m_GamePlay_RightMovement;
    private readonly InputAction m_GamePlay_BackMovement;
    public struct GamePlayActions
    {
        private @PlayerControllsMain m_Wrapper;
        public GamePlayActions(@PlayerControllsMain wrapper) { m_Wrapper = wrapper; }
        public InputAction @ForwardMovement => m_Wrapper.m_GamePlay_ForwardMovement;
        public InputAction @LeftMovement => m_Wrapper.m_GamePlay_LeftMovement;
        public InputAction @RightMovement => m_Wrapper.m_GamePlay_RightMovement;
        public InputAction @BackMovement => m_Wrapper.m_GamePlay_BackMovement;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
            {
                @ForwardMovement.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnForwardMovement;
                @ForwardMovement.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnForwardMovement;
                @ForwardMovement.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnForwardMovement;
                @LeftMovement.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnLeftMovement;
                @LeftMovement.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnLeftMovement;
                @LeftMovement.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnLeftMovement;
                @RightMovement.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRightMovement;
                @RightMovement.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRightMovement;
                @RightMovement.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnRightMovement;
                @BackMovement.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBackMovement;
                @BackMovement.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBackMovement;
                @BackMovement.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnBackMovement;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ForwardMovement.started += instance.OnForwardMovement;
                @ForwardMovement.performed += instance.OnForwardMovement;
                @ForwardMovement.canceled += instance.OnForwardMovement;
                @LeftMovement.started += instance.OnLeftMovement;
                @LeftMovement.performed += instance.OnLeftMovement;
                @LeftMovement.canceled += instance.OnLeftMovement;
                @RightMovement.started += instance.OnRightMovement;
                @RightMovement.performed += instance.OnRightMovement;
                @RightMovement.canceled += instance.OnRightMovement;
                @BackMovement.started += instance.OnBackMovement;
                @BackMovement.performed += instance.OnBackMovement;
                @BackMovement.canceled += instance.OnBackMovement;
            }
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);

    // main player controlls1
    private readonly InputActionMap m_mainplayercontrolls1;
    private IMainplayercontrolls1Actions m_Mainplayercontrolls1ActionsCallbackInterface;
    private readonly InputAction m_mainplayercontrolls1_ForwardMovement;
    private readonly InputAction m_mainplayercontrolls1_LeftMovement;
    private readonly InputAction m_mainplayercontrolls1_RightMovement;
    private readonly InputAction m_mainplayercontrolls1_BackMovement;
    public struct Mainplayercontrolls1Actions
    {
        private @PlayerControllsMain m_Wrapper;
        public Mainplayercontrolls1Actions(@PlayerControllsMain wrapper) { m_Wrapper = wrapper; }
        public InputAction @ForwardMovement => m_Wrapper.m_mainplayercontrolls1_ForwardMovement;
        public InputAction @LeftMovement => m_Wrapper.m_mainplayercontrolls1_LeftMovement;
        public InputAction @RightMovement => m_Wrapper.m_mainplayercontrolls1_RightMovement;
        public InputAction @BackMovement => m_Wrapper.m_mainplayercontrolls1_BackMovement;
        public InputActionMap Get() { return m_Wrapper.m_mainplayercontrolls1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Mainplayercontrolls1Actions set) { return set.Get(); }
        public void SetCallbacks(IMainplayercontrolls1Actions instance)
        {
            if (m_Wrapper.m_Mainplayercontrolls1ActionsCallbackInterface != null)
            {
                @ForwardMovement.started -= m_Wrapper.m_Mainplayercontrolls1ActionsCallbackInterface.OnForwardMovement;
                @ForwardMovement.performed -= m_Wrapper.m_Mainplayercontrolls1ActionsCallbackInterface.OnForwardMovement;
                @ForwardMovement.canceled -= m_Wrapper.m_Mainplayercontrolls1ActionsCallbackInterface.OnForwardMovement;
                @LeftMovement.started -= m_Wrapper.m_Mainplayercontrolls1ActionsCallbackInterface.OnLeftMovement;
                @LeftMovement.performed -= m_Wrapper.m_Mainplayercontrolls1ActionsCallbackInterface.OnLeftMovement;
                @LeftMovement.canceled -= m_Wrapper.m_Mainplayercontrolls1ActionsCallbackInterface.OnLeftMovement;
                @RightMovement.started -= m_Wrapper.m_Mainplayercontrolls1ActionsCallbackInterface.OnRightMovement;
                @RightMovement.performed -= m_Wrapper.m_Mainplayercontrolls1ActionsCallbackInterface.OnRightMovement;
                @RightMovement.canceled -= m_Wrapper.m_Mainplayercontrolls1ActionsCallbackInterface.OnRightMovement;
                @BackMovement.started -= m_Wrapper.m_Mainplayercontrolls1ActionsCallbackInterface.OnBackMovement;
                @BackMovement.performed -= m_Wrapper.m_Mainplayercontrolls1ActionsCallbackInterface.OnBackMovement;
                @BackMovement.canceled -= m_Wrapper.m_Mainplayercontrolls1ActionsCallbackInterface.OnBackMovement;
            }
            m_Wrapper.m_Mainplayercontrolls1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ForwardMovement.started += instance.OnForwardMovement;
                @ForwardMovement.performed += instance.OnForwardMovement;
                @ForwardMovement.canceled += instance.OnForwardMovement;
                @LeftMovement.started += instance.OnLeftMovement;
                @LeftMovement.performed += instance.OnLeftMovement;
                @LeftMovement.canceled += instance.OnLeftMovement;
                @RightMovement.started += instance.OnRightMovement;
                @RightMovement.performed += instance.OnRightMovement;
                @RightMovement.canceled += instance.OnRightMovement;
                @BackMovement.started += instance.OnBackMovement;
                @BackMovement.performed += instance.OnBackMovement;
                @BackMovement.canceled += instance.OnBackMovement;
            }
        }
    }
    public Mainplayercontrolls1Actions @mainplayercontrolls1 => new Mainplayercontrolls1Actions(this);
    public interface IGamePlayActions
    {
        void OnForwardMovement(InputAction.CallbackContext context);
        void OnLeftMovement(InputAction.CallbackContext context);
        void OnRightMovement(InputAction.CallbackContext context);
        void OnBackMovement(InputAction.CallbackContext context);
    }
    public interface IMainplayercontrolls1Actions
    {
        void OnForwardMovement(InputAction.CallbackContext context);
        void OnLeftMovement(InputAction.CallbackContext context);
        void OnRightMovement(InputAction.CallbackContext context);
        void OnBackMovement(InputAction.CallbackContext context);
    }
}
