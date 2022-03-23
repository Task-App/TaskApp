using System;
using UnityEngine;
using UnityEngine.UI;

public class SwitchPages : MonoBehaviour
{

    public GameObject homePanel, templatesPanel, settingsPanel;

    public Button homeButton, templatesButton, settingsButton;

    private Sprite _homeIcon,
        _homeIconFilled,
        _templatesIcon,
        _templatesIconFilled,
        _settingsIcon,
        _settingsIconFilled;

    private string _currButton;
    private void Start()
    {
        _currButton = "home";
        
        _homeIcon = Resources.Load<Sprite>("Icons/HomeIcon");
        _homeIconFilled = Resources.Load<Sprite>("Icons/HomeIconFilled");
        
        _templatesIcon = Resources.Load<Sprite>("Icons/TemplatesIcon");
        _templatesIconFilled = Resources.Load<Sprite>("Icons/TemplatesIconFilled");

        _settingsIcon = Resources.Load<Sprite>("Icons/SettingsIcon");
        _settingsIconFilled = Resources.Load<Sprite>("Icons/SettingsIconFilled");
    }

    // switches to home, handles button image change
    public void ToHome()
    {
        DeactivatePage();
        _currButton = "home";
        
        homeButton.image.sprite = _homeIconFilled;
        homePanel.SetActive(true);
    }

    // switches to home, handles button image change
    public void ToTemplates()
    {
        DeactivatePage();
        _currButton = "templates";
        
        templatesButton.image.sprite = _templatesIconFilled;
        templatesPanel.SetActive(true);
    }

    // switches to home, handles button image change
    public void ToSettings()
    {
        DeactivatePage();
        _currButton = "settings";
        
        settingsButton.image.sprite = _settingsIconFilled;
        settingsPanel.SetActive(true);
    }

    // un fills current button and deactivates page
    private void DeactivatePage()
    {
        switch (_currButton)
        {
            case "home":
                homeButton.image.sprite = _homeIcon;
                homePanel.SetActive(false);
                break;
            case "templates":
                templatesButton.image.sprite = _templatesIcon;
                templatesPanel.SetActive(false);
                break;
            case "settings":
                settingsButton.image.sprite = _settingsIcon;
                settingsPanel.SetActive(false);
                break;
        }
    }
    
}
