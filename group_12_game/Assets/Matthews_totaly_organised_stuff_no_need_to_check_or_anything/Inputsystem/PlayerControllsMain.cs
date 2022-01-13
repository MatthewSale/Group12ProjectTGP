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
                    ""name"": ""FowardMovment"",
                    ""type"": ""Button"",
                    ""id"": ""968b0a16-08f8-4d70-9da3-fa48027f19b0"",
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
                    ""action"": ""FowardMovment"",
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
                    ""action"": ""FowardMovment"",
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
                    ""action"": ""FowardMovment"",
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
                    ""action"": ""FowardMovment"",
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
                    ""name"": ""FowardMovment"",
                    ""type"": ""Button"",
                    ""id"": ""1e0cf6cb-9253-444a-a3a5-25f5a85fbd7d"",
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
                    ""action"": ""FowardMovment"",
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
                    ""action"": ""FowardMovment"",
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
                    ""action"": ""FowardMovment"",
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
                    ""action"": ""FowardMovment"",
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
        m_GamePlay_FowardMovment = m_GamePlay.FindAction("FowardMovment", throwIfNotFound: true);
        // main player controlls1
        m_mainplayercontrolls1 = asset.FindActionMap("main player controlls1", throwIfNotFound: true);
        m_mainplayercontrolls1_FowardMovment = m_mainplayercontrolls1.FindAction("FowardMovment", throwIfNotFound: true);
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
    private readonly InputAction m_GamePlay_FowardMovment;
    public struct GamePlayActions
    {
        private @PlayerControllsMain m_Wrapper;
        public GamePlayActions(@PlayerControllsMain wrapper) { m_Wrapper = wrapper; }
        public InputAction @FowardMovment => m_Wrapper.m_GamePlay_FowardMovment;
        public InputActionMap Get() { return m_Wrapper.m_GamePlay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamePlayActions set) { return set.Get(); }
        public void SetCallbacks(IGamePlayActions instance)
        {
            if (m_Wrapper.m_GamePlayActionsCallbackInterface != null)
            {
                @FowardMovment.started -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnFowardMovment;
                @FowardMovment.performed -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnFowardMovment;
                @FowardMovment.canceled -= m_Wrapper.m_GamePlayActionsCallbackInterface.OnFowardMovment;
            }
            m_Wrapper.m_GamePlayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @FowardMovment.started += instance.OnFowardMovment;
                @FowardMovment.performed += instance.OnFowardMovment;
                @FowardMovment.canceled += instance.OnFowardMovment;
            }
        }
    }
    public GamePlayActions @GamePlay => new GamePlayActions(this);

    // main player controlls1
    private readonly InputActionMap m_mainplayercontrolls1;
    private IMainplayercontrolls1Actions m_Mainplayercontrolls1ActionsCallbackInterface;
    private readonly InputAction m_mainplayercontrolls1_FowardMovment;
    public struct Mainplayercontrolls1Actions
    {
        private @PlayerControllsMain m_Wrapper;
        public Mainplayercontrolls1Actions(@PlayerControllsMain wrapper) { m_Wrapper = wrapper; }
        public InputAction @FowardMovment => m_Wrapper.m_mainplayercontrolls1_FowardMovment;
        public InputActionMap Get() { return m_Wrapper.m_mainplayercontrolls1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Mainplayercontrolls1Actions set) { return set.Get(); }
        public void SetCallbacks(IMainplayercontrolls1Actions instance)
        {
            if (m_Wrapper.m_Mainplayercontrolls1ActionsCallbackInterface != null)
            {
                @FowardMovment.started -= m_Wrapper.m_Mainplayercontrolls1ActionsCallbackInterface.OnFowardMovment;
                @FowardMovment.performed -= m_Wrapper.m_Mainplayercontrolls1ActionsCallbackInterface.OnFowardMovment;
                @FowardMovment.canceled -= m_Wrapper.m_Mainplayercontrolls1ActionsCallbackInterface.OnFowardMovment;
            }
            m_Wrapper.m_Mainplayercontrolls1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @FowardMovment.started += instance.OnFowardMovment;
                @FowardMovment.performed += instance.OnFowardMovment;
                @FowardMovment.canceled += instance.OnFowardMovment;
            }
        }
    }
    public Mainplayercontrolls1Actions @mainplayercontrolls1 => new Mainplayercontrolls1Actions(this);
    public interface IGamePlayActions
    {
        void OnFowardMovment(InputAction.CallbackContext context);
    }
    public interface IMainplayercontrolls1Actions
    {
        void OnFowardMovment(InputAction.CallbackContext context);
    }
}
