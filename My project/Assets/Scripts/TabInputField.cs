using UnityEngine;
using UnityEngine.UI;

public class TabInputField : MonoBehaviour
{
    public InputField[] inputFields;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            InputField currentInputField = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.GetComponent<InputField>();

            if (currentInputField != null)
            {
                int currentIndex = System.Array.IndexOf(inputFields, currentInputField);
                int nextIndex = (currentIndex + 1) % inputFields.Length;

                // 현재 선택된 InputField의 포커스 해제
                currentInputField.DeactivateInputField();

                // 다음 InputField로 이동
                inputFields[nextIndex].Select();
                inputFields[nextIndex].ActivateInputField();
            }
        }
    }
}