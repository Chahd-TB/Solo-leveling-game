using UnityEngine;
using UnityEngine.UI;  
using UnityEngine.EventSystems; 

public class code : MonoBehaviour
{
    public GameObject main;
    public GameObject settingsPanel;

    void Start()
    {
        main.SetActive(true);
        settingsPanel.SetActive(false);
    }

    public void OnSettingsButtonClicked()
    {
        main.SetActive(false);
        settingsPanel.SetActive(true);
    }
    public void BackButtonClicked()
    {
        main.SetActive(true);
        settingsPanel.SetActive(false);
    }
    public void Exit(){
        Application.Quit();
    }

}
