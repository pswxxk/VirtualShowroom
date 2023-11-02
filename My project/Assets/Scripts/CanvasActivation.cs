using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class CanvasActivation : MonoBehaviour
{
    public GameObject canvas; // Ȱ��ȭ�� ĵ����

    private OVRInput.Button yButton = OVRInput.Button.Two; // Oculus ��Ʈ�ѷ��� Y ��ư

    private bool isCanvasActive = false;

    private void Update()
    {
        // Oculus ��Ʈ�ѷ����� Y ��ư�� ������ ��
        if (OVRInput.GetDown(yButton))
        {
            // ĵ������ Ȱ��ȭ ���¸� ����
            isCanvasActive = !isCanvasActive;

            // ĵ���� Ȱ��ȭ/��Ȱ��ȭ ����
            canvas.SetActive(isCanvasActive);
            if (OVRInput.GetDown(yButton))
            {
                Debug.Log("Y ��ư�� ���Ƚ��ϴ�.");
                isCanvasActive = !isCanvasActive;
                canvas.SetActive(isCanvasActive);
            }
        }

    }


}