using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSelector : MonoBehaviour
{
    [SerializeField] private GameObject _roadMark_1;
    [SerializeField] private GameObject _roadMark_2;
    [SerializeField] private GameObject _roadMark_3;

    private int _roadIndex;

    private void OnEnable()
    {
        _roadIndex = PlayerPrefs.GetInt("road", 1);
        if (_roadIndex == 1)
        {
            _roadMark_1.SetActive(true);
        }
        else if (_roadIndex == 2)
        {
            _roadMark_2.SetActive(true);
        }
        else if (_roadIndex == 3)
        {
            _roadMark_3.SetActive(true);
        }
    }

    public void SelectFirstRoad()
    {
        _roadMark_1.SetActive(true);
        _roadMark_2.SetActive(false);
        _roadMark_3.SetActive(false);
        _roadIndex = 1;
    }

    public void SelectSecondRoad()
    {
        _roadMark_2.SetActive(true);
        _roadMark_1.SetActive(false);
        _roadMark_3.SetActive(false);
        _roadIndex = 2;
    }

    public void SelectThirdRoad()
    {
        _roadMark_3.SetActive(true);
        _roadMark_1.SetActive(false);
        _roadMark_2.SetActive(false);
        _roadIndex = 3;
    }

    private void OnDisable()
    {
        PlayerPrefs.SetInt("road", _roadIndex);
    }
}
