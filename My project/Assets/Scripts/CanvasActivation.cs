using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class CanvasActivation : MonoBehaviour
{
    public GameObject canvas; // Ȱ��ȭ�� ĵ����
    private bool isCanvasActive = false;

    private void Update()
    {
        // Oculus ��Ʈ�ѷ��� Y ��ư�� ������ ��
        if (InputDevices.GetDeviceAtXRNode(XRNode.RightHand).TryGetFeatureValue(CommonUsages.secondaryButton, out bool yButtonState) && yButtonState)
        {
            // ĵ������ Ȱ��ȭ ���¸� ����
            isCanvasActive = !isCanvasActive;

            // ĵ���� Ȱ��ȭ/��Ȱ��ȭ ����
            canvas.SetActive(isCanvasActive);
        }
    }
}