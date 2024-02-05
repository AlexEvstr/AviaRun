using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;

    [SerializeField] private GameObject _settingsPanel;

    [SerializeField] private GameObject _custimizerPanel;

    public void PlayBtn()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OpenSettings()
    {
        _mainMenu.SetActive(false);
        _settingsPanel.SetActive(true);
    }

    public void CloseSettings()
    {
        _settingsPanel.SetActive(false);
        _mainMenu.SetActive(true);
    }

    public void OpenCustomizer()
    {
        _mainMenu.SetActive(false);
        _custimizerPanel.SetActive(true);
    }

    public void CloseCustomizer()
    {
        _custimizerPanel.SetActive(false);
        _mainMenu.SetActive(true);
    }
}
