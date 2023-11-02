using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject startCanvas;
    public GameObject loginCanvas;
    public GameObject canvasToClose;
    public string targetScenename;

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

    public void OnClickLoginbutton()
    {
        SceneManager.LoadScene(targetScenename);
    }

    public void OnExitButtonClicked()
    {
        canvasToClose.SetActive(false);
    }


}