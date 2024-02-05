using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCollision : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverPanel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Double"))
        {
            Destroy(collision.gameObject);
            StartCoroutine(DoubleScore());
        }
        else if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(collision.gameObject);
            _gameOverPanel.SetActive(true);
        }
    }

    private IEnumerator DoubleScore()
    {
        Score.time = 0.5f;
        yield return new WaitForSeconds(5);
        Score.time = 1f;
    }
}