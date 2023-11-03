using UnityEngine;
using UnityEngine.XR;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OculusInputHandler : MonoBehaviour
{
    private InputField inputField;
    private InputDevice leftController;
    private InputDevice rightController;

    void Start()
    {
        inputField = GetComponent<InputField>();
        leftController = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
        rightController = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
    }

    void Update()
    {
        // Oculus VR 컨트롤러의 트리거 버튼을 누를 때마다 입력 처리
        if (leftController.TryGetFeatureValue(CommonUsages.trigger, out float leftTriggerValue) && leftTriggerValue > 0.1f && inputField.isFocused)
        {
            string input = leftTriggerValue.ToString();
            inputField.text += input;
        }

        if (rightController.TryGetFeatureValue(CommonUsages.trigger, out float rightTriggerValue) && rightTriggerValue > 0.1f && inputField.isFocused)
        {
            string input = rightTriggerValue.ToString();
            inputField.text += input;
        }

        // InputField를 터치하면 자판 띄우기
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (inputField.isFocused)
            {
                TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, false, false);
            }
        }
    }
}