using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleScoreMovement : MonoBehaviour
{
    private float _speed = 1f;
    private void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * _speed);
    }
}
