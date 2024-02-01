using DG.Tweening;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private bool _isMoving;

    private void Update()
    {
        if (_isMoving)
        {
            return;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            _isMoving = true;
            var delta = Mathf.Sign(Input.GetTouch(0).deltaPosition.x);
            var targetPosition = new Vector3(transform.position.x + delta, transform.position.y, transform.position.z);
            if (targetPosition.x == -3)
            {
                transform.DOMove(new Vector3(2, transform.position.y, -1), 0.3f)
                    .OnComplete(() => _isMoving = false);
            }
            else if (targetPosition.x == 3)
            {
                transform.DOMove(new Vector3(-2, transform.position.y, -1), 0.3f)
                    .OnComplete(() => _isMoving = false);
            }
            else 
            transform.DOMove(targetPosition, 0.3f)
                .OnComplete(() => _isMoving = false);
        }
    }
}