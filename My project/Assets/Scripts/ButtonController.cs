using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Sprite normalSprite;  // 노멀 상태 이미지
    public Sprite hoverSprite;   // 호버 상태 이미지
    public Sprite selectedSprite; // 셀렉티드 상태 이미지

    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.image.sprite = normalSprite; // 초기 이미지를 노멀 상태 이미지로 설정
    }

    public void OnHoverEnter()
    {
        button.image.sprite = hoverSprite; // 호버 상태로 이미지 변경
    }

    public void OnHoverExit()
    {
        button.image.sprite = normalSprite; // 노멀 상태로 이미지 변경
    }

    public void OnButtonClick()
    {
        button.image.sprite = selectedSprite; // 셀렉티드 상태로 이미지 변경
    }
}