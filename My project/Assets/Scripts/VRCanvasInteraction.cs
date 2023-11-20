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
        // DressPanel�� �ʱ⿡ Ȱ��ȭ�ϰ� �������� ��Ȱ��ȭ�մϴ�.
        topPanel.SetActive(false);
        pantsPanel.SetActive(false);
        dressPanel.SetActive(true);
        ShowRoomPanel.SetActive(false);
        chatImage.SetActive(false); 
    }

    public void OnTopPanelButtonClick()
    {
        // TopPanel ��ư�� Ŭ���Ǿ��� �� ȣ��Ǵ� �Լ�
        topPanel.SetActive(true);
        pantsPanel.SetActive(false);
        dressPanel.SetActive(false);
    }

    public void OnPantsPanelButtonClick()
    {
        // PantsPanel ��ư�� Ŭ���Ǿ��� �� ȣ��Ǵ� �Լ�
        topPanel.SetActive(false);
        pantsPanel.SetActive(true);
        dressPanel.SetActive(false);
    }

    public void OnDressPanelButtonClick()
    {
        // DressPanel ��ư�� Ŭ���Ǿ��� �� ȣ��Ǵ� �Լ�
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