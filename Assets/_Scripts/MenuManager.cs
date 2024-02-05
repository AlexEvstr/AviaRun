using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _settingsPanel;
    [SerializeField] private GameObject _custimizerPanel;
    [SerializeField] private GameObject _roadChanger;

    [SerializeField] private GameObject _soundOn;
    [SerializeField] private GameObject _soundOff;

    private bool _sound = true;

    private void OnEnable()
    {
        int sound = PlayerPrefs.GetInt("sound", -1);
        if (sound == 0)
        {
            _soundOn.SetActive(true);
            _soundOff.SetActive(false);
            _sound = true;
            AudioListener.volume = 1;
        }
        else if (sound == 1)
        {
            _soundOn.SetActive(false);
            _soundOff.SetActive(true);
            _sound = false;
            AudioListener.volume = 0;
        }
    }

    public void SoundOn()
    {
        _soundOn.SetActive(true);
        _soundOff.SetActive(false);
        AudioListener.volume = 1;
        _sound = true;
    }

    public void SoundOff()
    {
        _soundOn.SetActive(false);
        _soundOff.SetActive(true);
        AudioListener.volume = 0;
        _sound = false;
    }

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

    public void OpenRoadChanger()
    {
        _mainMenu.SetActive(false);
        _roadChanger.SetActive(true);
    }

    public void CloseRoadChanger()
    {
        _roadChanger.SetActive(false);
        _mainMenu.SetActive(true);
    }

    private void OnDisable()
    {
        if (_sound == true)
            PlayerPrefs.SetInt("sound", 0);
        else if (_sound == false)
            PlayerPrefs.SetInt("sound", 1);
    }
}