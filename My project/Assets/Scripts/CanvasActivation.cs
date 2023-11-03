using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class CanvasActivation : MonoBehaviour
{
    public GameObject canvas; // 활성화할 캔버스
    private bool isCanvasActive = false;

    private void Update()
    {
        // Oculus 컨트롤러의 Y 버튼이 눌렸을 때
        if (InputDevices.GetDeviceAtXRNode(XRNode.RightHand).TryGetFeatureValue(CommonUsages.secondaryButton, out bool yButtonState) && yButtonState)
        {
            // 캔버스의 활성화 상태를 변경
            isCanvasActive = !isCanvasActive;

            // 캔버스 활성화/비활성화 설정
            canvas.SetActive(isCanvasActive);
        }
    }
}