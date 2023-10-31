using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Sprite normalSprite;  // ��� ���� �̹���
    public Sprite hoverSprite;   // ȣ�� ���� �̹���
    public Sprite selectedSprite; // ����Ƽ�� ���� �̹���

    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.image.sprite = normalSprite; // �ʱ� �̹����� ��� ���� �̹����� ����
    }

    public void OnHoverEnter()
    {
        button.image.sprite = hoverSprite; // ȣ�� ���·� �̹��� ����
    }

    public void OnHoverExit()
    {
        button.image.sprite = normalSprite; // ��� ���·� �̹��� ����
    }

    public void OnButtonClick()
    {
        button.image.sprite = selectedSprite; // ����Ƽ�� ���·� �̹��� ����
    }
}