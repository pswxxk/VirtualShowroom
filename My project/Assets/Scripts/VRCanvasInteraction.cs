using UnityEngine;
using UnityEngine.UI;

public class VRCanvasInteraction : MonoBehaviour
{
    public GameObject fittingPanel;
    public GameObject topPanel;
    public GameObject pantsPanel;
    public GameObject dressPanel;
    public GameObject ShowRoomPanel;
    public GameObject chatImage;

    private void Start()
    {
        // DressPanel을 초기에 활성화하고 나머지는 비활성화합니다.
        topPanel.SetActive(false);
        pantsPanel.SetActive(false);
        dressPanel.SetActive(true);
        ShowRoomPanel.SetActive(false);
        chatImage.SetActive(false); 
    }

    public void OnTopPanelButtonClick()
    {
        // TopPanel 버튼이 클릭되었을 때 호출되는 함수
        topPanel.SetActive(true);
        pantsPanel.SetActive(false);
        dressPanel.SetActive(false);
    }

    public void OnPantsPanelButtonClick()
    {
        // PantsPanel 버튼이 클릭되었을 때 호출되는 함수
        topPanel.SetActive(false);
        pantsPanel.SetActive(true);
        dressPanel.SetActive(false);
    }

    public void OnDressPanelButtonClick()
    {
        // DressPanel 버튼이 클릭되었을 때 호출되는 함수
        topPanel.SetActive(false);
        pantsPanel.SetActive(false);
        dressPanel.SetActive(true);
    }

    public void OnShowRoomPanelButtonClick()
    { 
        fittingPanel.SetActive(false);
        topPanel.SetActive(false);
        pantsPanel.SetActive(false);
        dressPanel.SetActive(false);
        ShowRoomPanel.SetActive(true);
        chatImage.SetActive(false);
    }

    public void OnHomeButtonClick()
    {
        fittingPanel.SetActive(true);
        topPanel.SetActive(false);
        pantsPanel.SetActive(false);
        dressPanel.SetActive(true);
        ShowRoomPanel.SetActive(false);
        chatImage.SetActive(false);
    }

    public void OnEnterButtonClick()
    {
        chatImage.SetActive(true);
    }
}