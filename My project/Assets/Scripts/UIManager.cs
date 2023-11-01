using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject startCanvas;
    public GameObject loginCanvas;

    void Start()
    {

        startCanvas.SetActive(true);
        loginCanvas.SetActive(false);
    }

    public void OnStartButtonClicked()
    {

        startCanvas.SetActive(false);
        loginCanvas.SetActive(true);
    }


}