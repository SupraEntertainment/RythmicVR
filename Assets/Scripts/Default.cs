// GENERATED AUTOMATICALLY FROM 'Assets/Default.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Default : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Default()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Default"",
    ""maps"": [
        {
            ""name"": ""UI"",
            ""id"": ""0e7c516b-236b-4d62-a3f6-db001b648b9e"",
            ""actions"": [
                {
                    ""name"": ""click_ui"",
                    ""type"": ""Button"",
                    ""id"": ""6635163b-74e5-4e68-8337-2f971a2a1f49"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""scroll"",
                    ""type"": ""Value"",
                    ""id"": ""2e3213da-fe19-4d13-bae6-2fee63fc4d95"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2d9dfdaf-c31b-45ba-ac97-9582e576d4d8"",
                    ""path"": ""<XRController>/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""click_ui"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0dfbe098-9b94-4cf6-a928-2c7b98cc639c"",
                    ""path"": ""<XRController>/joystick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02d25e6d-c9a5-4a1a-a7dd-64291b28badb"",
                    ""path"": ""<XRController>/touchpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Tracking"",
            ""id"": ""e8c01aa9-0929-4067-96b1-44cfd336dd3c"",
            ""actions"": [
                {
                    ""name"": ""LeftControllerPosition"",
                    ""type"": ""Value"",
                    ""id"": ""a0ed3016-f373-451c-ac17-61a04c7b9f2c"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftControllerRotation"",
                    ""type"": ""Value"",
                    ""id"": ""aadf5181-f5cc-4a15-a70a-66918076c672"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightControllerPosition"",
                    ""type"": ""Value"",
                    ""id"": ""03e56336-1167-47e4-9087-92658a0027c5"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightControllerRotation"",
                    ""type"": ""Value"",
                    ""id"": ""09c7d600-e3e6-4050-87ed-7a5aa8c3daf2"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WaistTrackerPosition"",
                    ""type"": ""Value"",
                    ""id"": ""e08e55bc-d265-4fa7-b2c8-140488e93b9b"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WaistTrackerRotation"",
                    ""type"": ""Value"",
                    ""id"": ""0238a2e3-b4dd-4f02-90c3-1eb76a55fa70"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a03ba4e1-2fff-4633-b248-13653f7597c9"",
                    ""path"": ""<XRController>{LeftHand}/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftControllerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47729890-17f1-4d60-964b-4693789e2b0e"",
                    ""path"": ""<XRController>{LeftHand}/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftControllerRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a607d86a-a580-4d96-9cf8-a380f07ab20a"",
                    ""path"": ""<XRController>{RightHand}/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightControllerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff7f4e1e-805f-4f8b-a8dc-cbebe65542ab"",
                    ""path"": ""<XRController>{RightHand}/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightControllerRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f066a5ca-25a3-46ff-87a5-2607702aecb4"",
                    ""path"": ""<TrackedDevice>/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WaistTrackerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ddd2146-a8fe-4424-86c6-f3211a4af57d"",
                    ""path"": ""<TrackedDevice>/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WaistTrackerRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Default"",
            ""bindingGroup"": ""Default"",
            ""devices"": []
        }
    ]
}");
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_click_ui = m_UI.FindAction("click_ui", throwIfNotFound: true);
        m_UI_scroll = m_UI.FindAction("scroll", throwIfNotFound: true);
        // Tracking
        m_Tracking = asset.FindActionMap("Tracking", throwIfNotFound: true);
        m_Tracking_LeftControllerPosition = m_Tracking.FindAction("LeftControllerPosition", throwIfNotFound: true);
        m_Tracking_LeftControllerRotation = m_Tracking.FindAction("LeftControllerRotation", throwIfNotFound: true);
        m_Tracking_RightControllerPosition = m_Tracking.FindAction("RightControllerPosition", throwIfNotFound: true);
        m_Tracking_RightControllerRotation = m_Tracking.FindAction("RightControllerRotation", throwIfNotFound: true);
        m_Tracking_WaistTrackerPosition = m_Tracking.FindAction("WaistTrackerPosition", throwIfNotFound: true);
        m_Tracking_WaistTrackerRotation = m_Tracking.FindAction("WaistTrackerRotation", throwIfNotFound: true);
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

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_click_ui;
    private readonly InputAction m_UI_scroll;
    public struct UIActions
    {
        private @Default m_Wrapper;
        public UIActions(@Default wrapper) { m_Wrapper = wrapper; }
        public InputAction @click_ui => m_Wrapper.m_UI_click_ui;
        public InputAction @scroll => m_Wrapper.m_UI_scroll;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @click_ui.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick_ui;
                @click_ui.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick_ui;
                @click_ui.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick_ui;
                @scroll.started -= m_Wrapper.m_UIActionsCallbackInterface.OnScroll;
                @scroll.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnScroll;
                @scroll.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnScroll;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @click_ui.started += instance.OnClick_ui;
                @click_ui.performed += instance.OnClick_ui;
                @click_ui.canceled += instance.OnClick_ui;
                @scroll.started += instance.OnScroll;
                @scroll.performed += instance.OnScroll;
                @scroll.canceled += instance.OnScroll;
            }
        }
    }
    public UIActions @UI => new UIActions(this);

    // Tracking
    private readonly InputActionMap m_Tracking;
    private ITrackingActions m_TrackingActionsCallbackInterface;
    private readonly InputAction m_Tracking_LeftControllerPosition;
    private readonly InputAction m_Tracking_LeftControllerRotation;
    private readonly InputAction m_Tracking_RightControllerPosition;
    private readonly InputAction m_Tracking_RightControllerRotation;
    private readonly InputAction m_Tracking_WaistTrackerPosition;
    private readonly InputAction m_Tracking_WaistTrackerRotation;
    public struct TrackingActions
    {
        private @Default m_Wrapper;
        public TrackingActions(@Default wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftControllerPosition => m_Wrapper.m_Tracking_LeftControllerPosition;
        public InputAction @LeftControllerRotation => m_Wrapper.m_Tracking_LeftControllerRotation;
        public InputAction @RightControllerPosition => m_Wrapper.m_Tracking_RightControllerPosition;
        public InputAction @RightControllerRotation => m_Wrapper.m_Tracking_RightControllerRotation;
        public InputAction @WaistTrackerPosition => m_Wrapper.m_Tracking_WaistTrackerPosition;
        public InputAction @WaistTrackerRotation => m_Wrapper.m_Tracking_WaistTrackerRotation;
        public InputActionMap Get() { return m_Wrapper.m_Tracking; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TrackingActions set) { return set.Get(); }
        public void SetCallbacks(ITrackingActions instance)
        {
            if (m_Wrapper.m_TrackingActionsCallbackInterface != null)
            {
                @LeftControllerPosition.started -= m_Wrapper.m_TrackingActionsCallbackInterface.OnLeftControllerPosition;
                @LeftControllerPosition.performed -= m_Wrapper.m_TrackingActionsCallbackInterface.OnLeftControllerPosition;
                @LeftControllerPosition.canceled -= m_Wrapper.m_TrackingActionsCallbackInterface.OnLeftControllerPosition;
                @LeftControllerRotation.started -= m_Wrapper.m_TrackingActionsCallbackInterface.OnLeftControllerRotation;
                @LeftControllerRotation.performed -= m_Wrapper.m_TrackingActionsCallbackInterface.OnLeftControllerRotation;
                @LeftControllerRotation.canceled -= m_Wrapper.m_TrackingActionsCallbackInterface.OnLeftControllerRotation;
                @RightControllerPosition.started -= m_Wrapper.m_TrackingActionsCallbackInterface.OnRightControllerPosition;
                @RightControllerPosition.performed -= m_Wrapper.m_TrackingActionsCallbackInterface.OnRightControllerPosition;
                @RightControllerPosition.canceled -= m_Wrapper.m_TrackingActionsCallbackInterface.OnRightControllerPosition;
                @RightControllerRotation.started -= m_Wrapper.m_TrackingActionsCallbackInterface.OnRightControllerRotation;
                @RightControllerRotation.performed -= m_Wrapper.m_TrackingActionsCallbackInterface.OnRightControllerRotation;
                @RightControllerRotation.canceled -= m_Wrapper.m_TrackingActionsCallbackInterface.OnRightControllerRotation;
                @WaistTrackerPosition.started -= m_Wrapper.m_TrackingActionsCallbackInterface.OnWaistTrackerPosition;
                @WaistTrackerPosition.performed -= m_Wrapper.m_TrackingActionsCallbackInterface.OnWaistTrackerPosition;
                @WaistTrackerPosition.canceled -= m_Wrapper.m_TrackingActionsCallbackInterface.OnWaistTrackerPosition;
                @WaistTrackerRotation.started -= m_Wrapper.m_TrackingActionsCallbackInterface.OnWaistTrackerRotation;
                @WaistTrackerRotation.performed -= m_Wrapper.m_TrackingActionsCallbackInterface.OnWaistTrackerRotation;
                @WaistTrackerRotation.canceled -= m_Wrapper.m_TrackingActionsCallbackInterface.OnWaistTrackerRotation;
            }
            m_Wrapper.m_TrackingActionsCallbackInterface = instance;
            if (instance != null)
            {
                @LeftControllerPosition.started += instance.OnLeftControllerPosition;
                @LeftControllerPosition.performed += instance.OnLeftControllerPosition;
                @LeftControllerPosition.canceled += instance.OnLeftControllerPosition;
                @LeftControllerRotation.started += instance.OnLeftControllerRotation;
                @LeftControllerRotation.performed += instance.OnLeftControllerRotation;
                @LeftControllerRotation.canceled += instance.OnLeftControllerRotation;
                @RightControllerPosition.started += instance.OnRightControllerPosition;
                @RightControllerPosition.performed += instance.OnRightControllerPosition;
                @RightControllerPosition.canceled += instance.OnRightControllerPosition;
                @RightControllerRotation.started += instance.OnRightControllerRotation;
                @RightControllerRotation.performed += instance.OnRightControllerRotation;
                @RightControllerRotation.canceled += instance.OnRightControllerRotation;
                @WaistTrackerPosition.started += instance.OnWaistTrackerPosition;
                @WaistTrackerPosition.performed += instance.OnWaistTrackerPosition;
                @WaistTrackerPosition.canceled += instance.OnWaistTrackerPosition;
                @WaistTrackerRotation.started += instance.OnWaistTrackerRotation;
                @WaistTrackerRotation.performed += instance.OnWaistTrackerRotation;
                @WaistTrackerRotation.canceled += instance.OnWaistTrackerRotation;
            }
        }
    }
    public TrackingActions @Tracking => new TrackingActions(this);
    private int m_DefaultSchemeIndex = -1;
    public InputControlScheme DefaultScheme
    {
        get
        {
            if (m_DefaultSchemeIndex == -1) m_DefaultSchemeIndex = asset.FindControlSchemeIndex("Default");
            return asset.controlSchemes[m_DefaultSchemeIndex];
        }
    }
    public interface IUIActions
    {
        void OnClick_ui(InputAction.CallbackContext context);
        void OnScroll(InputAction.CallbackContext context);
    }
    public interface ITrackingActions
    {
        void OnLeftControllerPosition(InputAction.CallbackContext context);
        void OnLeftControllerRotation(InputAction.CallbackContext context);
        void OnRightControllerPosition(InputAction.CallbackContext context);
        void OnRightControllerRotation(InputAction.CallbackContext context);
        void OnWaistTrackerPosition(InputAction.CallbackContext context);
        void OnWaistTrackerRotation(InputAction.CallbackContext context);
    }
}
