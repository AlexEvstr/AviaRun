using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlane : MonoBehaviour
{
    [SerializeField] private Sprite _plane_1;
    [SerializeField] private Sprite _plane_2;
    [SerializeField] private Sprite _plane_3;

    [SerializeField] private SpriteRenderer _plane;

    private int _planeType;

    private void OnEnable()
    {
        _planeType = PlayerPrefs.GetInt("plane", 1);
        if (_planeType == 1)
        {
            _plane.sprite = _plane_1;
        }
        else if (_planeType == 2)
        {
            _plane.sprite = _plane_2;
        }
        else if (_planeType == 3)
        {
            _plane.sprite = _plane_3;
        }
    }
}
