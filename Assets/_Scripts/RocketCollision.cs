using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketCollision : MonoBehaviour
{
    [SerializeField] private GameObject _explosion;
    [SerializeField] private GameObject _doubleScoreBonus;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if (!collision.gameObject.CompareTag("Player") && !collision.gameObject.CompareTag("Obstacle") && !collision.gameObject.CompareTag("Bonus"))
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            GameObject explosion = Instantiate(_explosion);
            explosion.transform.position = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, collision.gameObject.transform.position.z);

            int chance = Random.Range(0, 100);
            if (chance > 80)
            {
                GameObject doubleScoreBonus = Instantiate(_doubleScoreBonus);
                doubleScoreBonus.transform.position = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, collision.gameObject.transform.position.z);
            }   
        }
    }
}