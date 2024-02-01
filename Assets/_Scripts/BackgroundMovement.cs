using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    private float _speed = 3.0f;

    private void Update()
    {
        transform.Translate(Vector2.down * Time.deltaTime * _speed);
        if (transform.position.y <= -11)
        {
            transform.position = new Vector2(0,11);
        }
    }
}