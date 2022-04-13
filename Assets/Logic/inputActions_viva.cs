// GENERATED AUTOMATICALLY FROM 'Assets/Logic/inputActions_viva.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions_viva : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions_viva()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""inputActions_viva"",
    ""maps"": [
        {
            ""name"": ""keyboard"",
            ""id"": ""eb459591-4014-468b-8cee-68a48cd78f73"",
            ""actions"": [
                {
                    ""name"": ""movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""81f0c277-c2b6-4fe2-87f6-cf24b562bb6e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""extendRight"",
                    ""type"": ""Button"",
                    ""id"": ""07bd9f8e-cd08-42d8-b2df-aa2716310bd8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""extendLeft"",
                    ""type"": ""Button"",
                    ""id"": ""440233d2-e56e-463d-99be-8e23bba0a3b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""wave"",
                    ""type"": ""Button"",
                    ""id"": ""dad4c442-1e0e-4c8f-b06e-4392ddd7e04f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""follow"",
                    ""type"": ""Button"",
                    ""id"": ""a6f37fa6-b8c2-4b6d-97a5-520d20239f53"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""pauseButton"",
                    ""type"": ""Button"",
                    ""id"": ""129a5773-95ca-458a-9933-461d91e93a65"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""keyboardAlt"",
                    ""type"": ""Button"",
                    ""id"": ""8d9a8e1c-0186-4840-b785-4b1d45c9be46"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""rightInteract"",
                    ""type"": ""Button"",
                    ""id"": ""1d6323e7-1a6f-448f-88f0-d726d9b06948"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""leftInteract"",
                    ""type"": ""Button"",
                    ""id"": ""cb20c011-5e2b-4e0d-a1e5-5b507c8a76e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""mouseVelocity"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d1c82cfb-895e-4756-86cb-2dd12e7d8fb6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""mousePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7d724695-8d56-4a17-a3e3-9b11a01fe9fa"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""crouch"",
                    ""type"": ""Button"",
                    ""id"": ""5594723d-bfd5-4c74-a507-bd20037de005"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""w"",
                    ""type"": ""Button"",
                    ""id"": ""154b3263-5503-4ad5-97ae-a1d670f64399"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""a"",
                    ""type"": ""Button"",
                    ""id"": ""79877d24-6410-4e62-b9cd-ce217371c73e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""s"",
                    ""type"": ""Button"",
                    ""id"": ""371d95be-9bf4-49cc-9133-331acd5884e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""d"",
                    ""type"": ""Button"",
                    ""id"": ""291b99e9-23cf-4f74-9f87-7c92343cf01a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""795be110-47fe-4754-892c-77c0cdf291ac"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1b82e536-12ab-48ee-9d14-8553f20eade4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""562bda70-779d-4fd6-9125-6fbf2a7ccec3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3a150b00-cbf9-47a4-95fb-4b0538168722"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d2ca818c-1d03-45bc-8e68-d076636f621a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0a46f3dc-d408-4419-b78a-a3bbf9a5679f"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""extendLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ed4bc1b-fa83-438e-9b6e-8c0523d566f4"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""wave"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6033d847-c899-4be4-9717-fa730ac4dd02"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""follow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c009b2a-ed3a-4557-a526-c793a9e560ea"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""extendRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""49dc878c-6bae-4e2d-8fc6-22b4f35ceab3"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""pauseButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb808b91-5e22-4e2a-b902-787b6f387fd3"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""keyboardAlt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7e14871-e7cc-4eb1-af46-c4f5098b0412"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rightInteract"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b54c15f6-4427-41ba-bed0-7399e2e6bad6"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""leftInteract"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""243891fa-c80c-4620-85b4-060ef95c274f"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mouseVelocity"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d2b96229-72b9-4793-948f-02fd583e0698"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""mousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0aec2d5-106c-41e3-8b59-5b507f244731"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab4cabfa-f357-46da-b82e-d7ed7b1f78de"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""w"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8a0330cb-a74d-4d76-854e-16c11c3efa10"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""s"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a7a1e39c-774f-4e86-8537-87c0f69f04ad"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""d"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27b5204e-f398-4f43-bd6b-ff90bdfd3f89"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""a"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""vr"",
            ""id"": ""3cdc15a5-f698-4dd9-a620-f06dbea65896"",
            ""actions"": [
                {
                    ""name"": ""rightTrackpad"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2d70a984-2654-4d7f-9fbb-3416663f47e5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""leftTrackpad"",
                    ""type"": ""PassThrough"",
                    ""id"": ""95e39184-ee92-4657-836d-6128f68f7a4c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""rightTrackpadButton"",
                    ""type"": ""Button"",
                    ""id"": ""6700793e-43ee-44df-bd2f-e1945306c7b6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""leftTrackpadButton"",
                    ""type"": ""Button"",
                    ""id"": ""ade0eb2f-ac26-41ea-88fa-cb36447a953c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""rightGrip"",
                    ""type"": ""Value"",
                    ""id"": ""bb3ab885-f00f-439e-828d-79b82e254873"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""leftGrip"",
                    ""type"": ""Value"",
                    ""id"": ""c4328b04-198d-40eb-af4c-fe87b6f6998b"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""rightAction"",
                    ""type"": ""Button"",
                    ""id"": ""9fd7971e-16c8-46cc-8a55-3face60ed430"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""leftAction"",
                    ""type"": ""Button"",
                    ""id"": ""f3f8b25f-34c0-48d4-b927-9a872d7a9d3c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""rightPauseButton"",
                    ""type"": ""Button"",
                    ""id"": ""4730eda3-98f8-46b6-823b-c3bd56253d62"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""leftPauseButton"",
                    ""type"": ""Button"",
                    ""id"": ""e9614f09-cf4a-4748-a023-ace798b9fe1e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a3e14343-a988-49f5-bbeb-9c6ec7e26b2e"",
                    ""path"": ""<OpenVRControllerIndex>{RightHand}/gripGrab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rightGrip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0328f881-8e3f-40ff-8d3f-09f4fd6f5626"",
                    ""path"": ""<OpenVRControllerIndex>{RightHand}/joystick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rightTrackpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""88bb7524-fd9c-4dff-9ea8-37084358ba21"",
                    ""path"": ""<OpenVRControllerIndex>{RightHand}/joystickClick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rightTrackpadButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""88287ee7-b2dd-428f-ac68-e94d95b0a961"",
                    ""path"": ""<OpenVRControllerIndex>{LeftHand}/joystickClick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""leftTrackpadButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50b01fd7-5e5a-482f-9439-5f7ab433db5a"",
                    ""path"": ""<OpenVRControllerIndex>{RightHand}/triggerButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rightAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5951063-fc6f-46ba-98ca-79d681ec8951"",
                    ""path"": ""<OpenVRControllerIndex>{LeftHand}/triggerButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""leftAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97d6e7ab-9acc-4520-9aff-9cc0ebc2b039"",
                    ""path"": ""<OpenVRControllerIndex>{LeftHand}/gripGrab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""leftGrip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d0adc8f-013c-4709-94e3-863259d0445d"",
                    ""path"": ""<OpenVRControllerIndex>{RightHand}/bButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rightPauseButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ebf5a4a-b015-4c6b-963b-16e1f21ff4c3"",
                    ""path"": ""<OpenVRControllerIndex>{LeftHand}/bButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""leftPauseButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb69a798-ccf6-49c2-8c9a-c78d9e7e05ce"",
                    ""path"": ""<OpenVRControllerIndex>{LeftHand}/joystick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""leftTrackpad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // keyboard
        m_keyboard = asset.FindActionMap("keyboard", throwIfNotFound: true);
        m_keyboard_movement = m_keyboard.FindAction("movement", throwIfNotFound: true);
        m_keyboard_extendRight = m_keyboard.FindAction("extendRight", throwIfNotFound: true);
        m_keyboard_extendLeft = m_keyboard.FindAction("extendLeft", throwIfNotFound: true);
        m_keyboard_wave = m_keyboard.FindAction("wave", throwIfNotFound: true);
        m_keyboard_follow = m_keyboard.FindAction("follow", throwIfNotFound: true);
        m_keyboard_pauseButton = m_keyboard.FindAction("pauseButton", throwIfNotFound: true);
        m_keyboard_keyboardAlt = m_keyboard.FindAction("keyboardAlt", throwIfNotFound: true);
        m_keyboard_rightInteract = m_keyboard.FindAction("rightInteract", throwIfNotFound: true);
        m_keyboard_leftInteract = m_keyboard.FindAction("leftInteract", throwIfNotFound: true);
        m_keyboard_mouseVelocity = m_keyboard.FindAction("mouseVelocity", throwIfNotFound: true);
        m_keyboard_mousePosition = m_keyboard.FindAction("mousePosition", throwIfNotFound: true);
        m_keyboard_crouch = m_keyboard.FindAction("crouch", throwIfNotFound: true);
        m_keyboard_w = m_keyboard.FindAction("w", throwIfNotFound: true);
        m_keyboard_a = m_keyboard.FindAction("a", throwIfNotFound: true);
        m_keyboard_s = m_keyboard.FindAction("s", throwIfNotFound: true);
        m_keyboard_d = m_keyboard.FindAction("d", throwIfNotFound: true);
        // vr
        m_vr = asset.FindActionMap("vr", throwIfNotFound: true);
        m_vr_rightTrackpad = m_vr.FindAction("rightTrackpad", throwIfNotFound: true);
        m_vr_leftTrackpad = m_vr.FindAction("leftTrackpad", throwIfNotFound: true);
        m_vr_rightTrackpadButton = m_vr.FindAction("rightTrackpadButton", throwIfNotFound: true);
        m_vr_leftTrackpadButton = m_vr.FindAction("leftTrackpadButton", throwIfNotFound: true);
        m_vr_rightGrip = m_vr.FindAction("rightGrip", throwIfNotFound: true);
        m_vr_leftGrip = m_vr.FindAction("leftGrip", throwIfNotFound: true);
        m_vr_rightAction = m_vr.FindAction("rightAction", throwIfNotFound: true);
        m_vr_leftAction = m_vr.FindAction("leftAction", throwIfNotFound: true);
        m_vr_rightPauseButton = m_vr.FindAction("rightPauseButton", throwIfNotFound: true);
        m_vr_leftPauseButton = m_vr.FindAction("leftPauseButton", throwIfNotFound: true);
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

    // keyboard
    private readonly InputActionMap m_keyboard;
    private IKeyboardActions m_KeyboardActionsCallbackInterface;
    private readonly InputAction m_keyboard_movement;
    private readonly InputAction m_keyboard_extendRight;
    private readonly InputAction m_keyboard_extendLeft;
    private readonly InputAction m_keyboard_wave;
    private readonly InputAction m_keyboard_follow;
    private readonly InputAction m_keyboard_pauseButton;
    private readonly InputAction m_keyboard_keyboardAlt;
    private readonly InputAction m_keyboard_rightInteract;
    private readonly InputAction m_keyboard_leftInteract;
    private readonly InputAction m_keyboard_mouseVelocity;
    private readonly InputAction m_keyboard_mousePosition;
    private readonly InputAction m_keyboard_crouch;
    private readonly InputAction m_keyboard_w;
    private readonly InputAction m_keyboard_a;
    private readonly InputAction m_keyboard_s;
    private readonly InputAction m_keyboard_d;
    public struct KeyboardActions
    {
        private @InputActions_viva m_Wrapper;
        public KeyboardActions(@InputActions_viva wrapper) { m_Wrapper = wrapper; }
        public InputAction @movement => m_Wrapper.m_keyboard_movement;
        public InputAction @extendRight => m_Wrapper.m_keyboard_extendRight;
        public InputAction @extendLeft => m_Wrapper.m_keyboard_extendLeft;
        public InputAction @wave => m_Wrapper.m_keyboard_wave;
        public InputAction @follow => m_Wrapper.m_keyboard_follow;
        public InputAction @pauseButton => m_Wrapper.m_keyboard_pauseButton;
        public InputAction @keyboardAlt => m_Wrapper.m_keyboard_keyboardAlt;
        public InputAction @rightInteract => m_Wrapper.m_keyboard_rightInteract;
        public InputAction @leftInteract => m_Wrapper.m_keyboard_leftInteract;
        public InputAction @mouseVelocity => m_Wrapper.m_keyboard_mouseVelocity;
        public InputAction @mousePosition => m_Wrapper.m_keyboard_mousePosition;
        public InputAction @crouch => m_Wrapper.m_keyboard_crouch;
        public InputAction @w => m_Wrapper.m_keyboard_w;
        public InputAction @a => m_Wrapper.m_keyboard_a;
        public InputAction @s => m_Wrapper.m_keyboard_s;
        public InputAction @d => m_Wrapper.m_keyboard_d;
        public InputActionMap Get() { return m_Wrapper.m_keyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardActions instance)
        {
            if (m_Wrapper.m_KeyboardActionsCallbackInterface != null)
            {
                @movement.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMovement;
                @movement.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMovement;
                @movement.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMovement;
                @extendRight.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnExtendRight;
                @extendRight.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnExtendRight;
                @extendRight.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnExtendRight;
                @extendLeft.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnExtendLeft;
                @extendLeft.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnExtendLeft;
                @extendLeft.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnExtendLeft;
                @wave.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnWave;
                @wave.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnWave;
                @wave.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnWave;
                @follow.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnFollow;
                @follow.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnFollow;
                @follow.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnFollow;
                @pauseButton.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnPauseButton;
                @pauseButton.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnPauseButton;
                @pauseButton.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnPauseButton;
                @keyboardAlt.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnKeyboardAlt;
                @keyboardAlt.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnKeyboardAlt;
                @keyboardAlt.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnKeyboardAlt;
                @rightInteract.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnRightInteract;
                @rightInteract.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnRightInteract;
                @rightInteract.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnRightInteract;
                @leftInteract.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLeftInteract;
                @leftInteract.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLeftInteract;
                @leftInteract.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnLeftInteract;
                @mouseVelocity.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMouseVelocity;
                @mouseVelocity.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMouseVelocity;
                @mouseVelocity.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMouseVelocity;
                @mousePosition.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMousePosition;
                @mousePosition.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMousePosition;
                @mousePosition.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnMousePosition;
                @crouch.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnCrouch;
                @crouch.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnCrouch;
                @crouch.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnCrouch;
                @w.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnW;
                @w.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnW;
                @w.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnW;
                @a.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnA;
                @a.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnA;
                @a.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnA;
                @s.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnS;
                @s.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnS;
                @s.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnS;
                @d.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnD;
                @d.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnD;
                @d.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnD;
            }
            m_Wrapper.m_KeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @movement.started += instance.OnMovement;
                @movement.performed += instance.OnMovement;
                @movement.canceled += instance.OnMovement;
                @extendRight.started += instance.OnExtendRight;
                @extendRight.performed += instance.OnExtendRight;
                @extendRight.canceled += instance.OnExtendRight;
                @extendLeft.started += instance.OnExtendLeft;
                @extendLeft.performed += instance.OnExtendLeft;
                @extendLeft.canceled += instance.OnExtendLeft;
                @wave.started += instance.OnWave;
                @wave.performed += instance.OnWave;
                @wave.canceled += instance.OnWave;
                @follow.started += instance.OnFollow;
                @follow.performed += instance.OnFollow;
                @follow.canceled += instance.OnFollow;
                @pauseButton.started += instance.OnPauseButton;
                @pauseButton.performed += instance.OnPauseButton;
                @pauseButton.canceled += instance.OnPauseButton;
                @keyboardAlt.started += instance.OnKeyboardAlt;
                @keyboardAlt.performed += instance.OnKeyboardAlt;
                @keyboardAlt.canceled += instance.OnKeyboardAlt;
                @rightInteract.started += instance.OnRightInteract;
                @rightInteract.performed += instance.OnRightInteract;
                @rightInteract.canceled += instance.OnRightInteract;
                @leftInteract.started += instance.OnLeftInteract;
                @leftInteract.performed += instance.OnLeftInteract;
                @leftInteract.canceled += instance.OnLeftInteract;
                @mouseVelocity.started += instance.OnMouseVelocity;
                @mouseVelocity.performed += instance.OnMouseVelocity;
                @mouseVelocity.canceled += instance.OnMouseVelocity;
                @mousePosition.started += instance.OnMousePosition;
                @mousePosition.performed += instance.OnMousePosition;
                @mousePosition.canceled += instance.OnMousePosition;
                @crouch.started += instance.OnCrouch;
                @crouch.performed += instance.OnCrouch;
                @crouch.canceled += instance.OnCrouch;
                @w.started += instance.OnW;
                @w.performed += instance.OnW;
                @w.canceled += instance.OnW;
                @a.started += instance.OnA;
                @a.performed += instance.OnA;
                @a.canceled += instance.OnA;
                @s.started += instance.OnS;
                @s.performed += instance.OnS;
                @s.canceled += instance.OnS;
                @d.started += instance.OnD;
                @d.performed += instance.OnD;
                @d.canceled += instance.OnD;
            }
        }
    }
    public KeyboardActions @keyboard => new KeyboardActions(this);

    // vr
    private readonly InputActionMap m_vr;
    private IVrActions m_VrActionsCallbackInterface;
    private readonly InputAction m_vr_rightTrackpad;
    private readonly InputAction m_vr_leftTrackpad;
    private readonly InputAction m_vr_rightTrackpadButton;
    private readonly InputAction m_vr_leftTrackpadButton;
    private readonly InputAction m_vr_rightGrip;
    private readonly InputAction m_vr_leftGrip;
    private readonly InputAction m_vr_rightAction;
    private readonly InputAction m_vr_leftAction;
    private readonly InputAction m_vr_rightPauseButton;
    private readonly InputAction m_vr_leftPauseButton;
    public struct VrActions
    {
        private @InputActions_viva m_Wrapper;
        public VrActions(@InputActions_viva wrapper) { m_Wrapper = wrapper; }
        public InputAction @rightTrackpad => m_Wrapper.m_vr_rightTrackpad;
        public InputAction @leftTrackpad => m_Wrapper.m_vr_leftTrackpad;
        public InputAction @rightTrackpadButton => m_Wrapper.m_vr_rightTrackpadButton;
        public InputAction @leftTrackpadButton => m_Wrapper.m_vr_leftTrackpadButton;
        public InputAction @rightGrip => m_Wrapper.m_vr_rightGrip;
        public InputAction @leftGrip => m_Wrapper.m_vr_leftGrip;
        public InputAction @rightAction => m_Wrapper.m_vr_rightAction;
        public InputAction @leftAction => m_Wrapper.m_vr_leftAction;
        public InputAction @rightPauseButton => m_Wrapper.m_vr_rightPauseButton;
        public InputAction @leftPauseButton => m_Wrapper.m_vr_leftPauseButton;
        public InputActionMap Get() { return m_Wrapper.m_vr; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(VrActions set) { return set.Get(); }
        public void SetCallbacks(IVrActions instance)
        {
            if (m_Wrapper.m_VrActionsCallbackInterface != null)
            {
                @rightTrackpad.started -= m_Wrapper.m_VrActionsCallbackInterface.OnRightTrackpad;
                @rightTrackpad.performed -= m_Wrapper.m_VrActionsCallbackInterface.OnRightTrackpad;
                @rightTrackpad.canceled -= m_Wrapper.m_VrActionsCallbackInterface.OnRightTrackpad;
                @leftTrackpad.started -= m_Wrapper.m_VrActionsCallbackInterface.OnLeftTrackpad;
                @leftTrackpad.performed -= m_Wrapper.m_VrActionsCallbackInterface.OnLeftTrackpad;
                @leftTrackpad.canceled -= m_Wrapper.m_VrActionsCallbackInterface.OnLeftTrackpad;
                @rightTrackpadButton.started -= m_Wrapper.m_VrActionsCallbackInterface.OnRightTrackpadButton;
                @rightTrackpadButton.performed -= m_Wrapper.m_VrActionsCallbackInterface.OnRightTrackpadButton;
                @rightTrackpadButton.canceled -= m_Wrapper.m_VrActionsCallbackInterface.OnRightTrackpadButton;
                @leftTrackpadButton.started -= m_Wrapper.m_VrActionsCallbackInterface.OnLeftTrackpadButton;
                @leftTrackpadButton.performed -= m_Wrapper.m_VrActionsCallbackInterface.OnLeftTrackpadButton;
                @leftTrackpadButton.canceled -= m_Wrapper.m_VrActionsCallbackInterface.OnLeftTrackpadButton;
                @rightGrip.started -= m_Wrapper.m_VrActionsCallbackInterface.OnRightGrip;
                @rightGrip.performed -= m_Wrapper.m_VrActionsCallbackInterface.OnRightGrip;
                @rightGrip.canceled -= m_Wrapper.m_VrActionsCallbackInterface.OnRightGrip;
                @leftGrip.started -= m_Wrapper.m_VrActionsCallbackInterface.OnLeftGrip;
                @leftGrip.performed -= m_Wrapper.m_VrActionsCallbackInterface.OnLeftGrip;
                @leftGrip.canceled -= m_Wrapper.m_VrActionsCallbackInterface.OnLeftGrip;
                @rightAction.started -= m_Wrapper.m_VrActionsCallbackInterface.OnRightAction;
                @rightAction.performed -= m_Wrapper.m_VrActionsCallbackInterface.OnRightAction;
                @rightAction.canceled -= m_Wrapper.m_VrActionsCallbackInterface.OnRightAction;
                @leftAction.started -= m_Wrapper.m_VrActionsCallbackInterface.OnLeftAction;
                @leftAction.performed -= m_Wrapper.m_VrActionsCallbackInterface.OnLeftAction;
                @leftAction.canceled -= m_Wrapper.m_VrActionsCallbackInterface.OnLeftAction;
                @rightPauseButton.started -= m_Wrapper.m_VrActionsCallbackInterface.OnRightPauseButton;
                @rightPauseButton.performed -= m_Wrapper.m_VrActionsCallbackInterface.OnRightPauseButton;
                @rightPauseButton.canceled -= m_Wrapper.m_VrActionsCallbackInterface.OnRightPauseButton;
                @leftPauseButton.started -= m_Wrapper.m_VrActionsCallbackInterface.OnLeftPauseButton;
                @leftPauseButton.performed -= m_Wrapper.m_VrActionsCallbackInterface.OnLeftPauseButton;
                @leftPauseButton.canceled -= m_Wrapper.m_VrActionsCallbackInterface.OnLeftPauseButton;
            }
            m_Wrapper.m_VrActionsCallbackInterface = instance;
            if (instance != null)
            {
                @rightTrackpad.started += instance.OnRightTrackpad;
                @rightTrackpad.performed += instance.OnRightTrackpad;
                @rightTrackpad.canceled += instance.OnRightTrackpad;
                @leftTrackpad.started += instance.OnLeftTrackpad;
                @leftTrackpad.performed += instance.OnLeftTrackpad;
                @leftTrackpad.canceled += instance.OnLeftTrackpad;
                @rightTrackpadButton.started += instance.OnRightTrackpadButton;
                @rightTrackpadButton.performed += instance.OnRightTrackpadButton;
                @rightTrackpadButton.canceled += instance.OnRightTrackpadButton;
                @leftTrackpadButton.started += instance.OnLeftTrackpadButton;
                @leftTrackpadButton.performed += instance.OnLeftTrackpadButton;
                @leftTrackpadButton.canceled += instance.OnLeftTrackpadButton;
                @rightGrip.started += instance.OnRightGrip;
                @rightGrip.performed += instance.OnRightGrip;
                @rightGrip.canceled += instance.OnRightGrip;
                @leftGrip.started += instance.OnLeftGrip;
                @leftGrip.performed += instance.OnLeftGrip;
                @leftGrip.canceled += instance.OnLeftGrip;
                @rightAction.started += instance.OnRightAction;
                @rightAction.performed += instance.OnRightAction;
                @rightAction.canceled += instance.OnRightAction;
                @leftAction.started += instance.OnLeftAction;
                @leftAction.performed += instance.OnLeftAction;
                @leftAction.canceled += instance.OnLeftAction;
                @rightPauseButton.started += instance.OnRightPauseButton;
                @rightPauseButton.performed += instance.OnRightPauseButton;
                @rightPauseButton.canceled += instance.OnRightPauseButton;
                @leftPauseButton.started += instance.OnLeftPauseButton;
                @leftPauseButton.performed += instance.OnLeftPauseButton;
                @leftPauseButton.canceled += instance.OnLeftPauseButton;
            }
        }
    }
    public VrActions @vr => new VrActions(this);
    public interface IKeyboardActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnExtendRight(InputAction.CallbackContext context);
        void OnExtendLeft(InputAction.CallbackContext context);
        void OnWave(InputAction.CallbackContext context);
        void OnFollow(InputAction.CallbackContext context);
        void OnPauseButton(InputAction.CallbackContext context);
        void OnKeyboardAlt(InputAction.CallbackContext context);
        void OnRightInteract(InputAction.CallbackContext context);
        void OnLeftInteract(InputAction.CallbackContext context);
        void OnMouseVelocity(InputAction.CallbackContext context);
        void OnMousePosition(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnW(InputAction.CallbackContext context);
        void OnA(InputAction.CallbackContext context);
        void OnS(InputAction.CallbackContext context);
        void OnD(InputAction.CallbackContext context);
    }
    public interface IVrActions
    {
        void OnRightTrackpad(InputAction.CallbackContext context);
        void OnLeftTrackpad(InputAction.CallbackContext context);
        void OnRightTrackpadButton(InputAction.CallbackContext context);
        void OnLeftTrackpadButton(InputAction.CallbackContext context);
        void OnRightGrip(InputAction.CallbackContext context);
        void OnLeftGrip(InputAction.CallbackContext context);
        void OnRightAction(InputAction.CallbackContext context);
        void OnLeftAction(InputAction.CallbackContext context);
        void OnRightPauseButton(InputAction.CallbackContext context);
        void OnLeftPauseButton(InputAction.CallbackContext context);
    }
}
