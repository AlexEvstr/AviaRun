using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckRoad : MonoBehaviour
{
    [SerializeField] private Sprite _road_1;
    [SerializeField] private Sprite _road_2;
    [SerializeField] private Sprite _road_3;

    [SerializeField] private SpriteRenderer _bg_1;
    [SerializeField] private SpriteRenderer _bg_2;

    private int _planeType;

    private void OnEnable()
    {
        _planeType = PlayerPrefs.GetInt("road", 1);
        if (_planeType == 1)
        {
            _bg_1.sprite = _road_1;
            _bg_2.sprite = _road_1;
        }
        else if (_planeType == 2)
        {
            _bg_1.sprite = _road_2;
            _bg_2.sprite = _road_2;
        }
        else if (_planeType == 3)
        {
            _bg_1.sprite = _road_3;
            _bg_2.sprite = _road_3;
        }
    }
}
