using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Double"))
        {
            Destroy(collision.gameObject);
            StartCoroutine(DoubleScore());
        }
    }

    private IEnumerator DoubleScore()
    {
        Score.time = 0.5f;
        yield return new WaitForSeconds(5);
        Score.time = 1f;
    }

    //private void Update()
    //{
    //    Debug.Log(Score.time);
    //}
}
