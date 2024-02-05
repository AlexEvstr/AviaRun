using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneSelector : MonoBehaviour
{
    [SerializeField] private GameObject _mark_1;
    [SerializeField] private GameObject _mark_2;
    [SerializeField] private GameObject _mark_3;

    private int _planeIndex;

    private void OnEnable()
    {
        _planeIndex = PlayerPrefs.GetInt("plane", 1);
        if (_planeIndex == 1)
        {
            _mark_1.SetActive(true);
        }
        else if (_planeIndex == 2)
        {
            _mark_2.SetActive(true);
        }
        else if (_planeIndex == 3)
        {
            _mark_3.SetActive(true);
        }
    }

    public void SelectFirstPlane()
    {
        _mark_1.SetActive(true);
        _mark_2.SetActive(false);
        _mark_3.SetActive(false);
        _planeIndex = 1;
    }

    public void SelectSecondPlane()
    {
        _mark_2.SetActive(true);
        _mark_1.SetActive(false);
        _mark_3.SetActive(false);
        _planeIndex = 2;
    }

    public void SelectThirdPlane()
    {
        _mark_3.SetActive(true);
        _mark_1.SetActive(false);
        _mark_2.SetActive(false);
        _planeIndex = 3;
    }

    private void OnDisable()
    {
        PlayerPrefs.SetInt("plane", _planeIndex);
    }
}