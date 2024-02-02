using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _obstacle;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            GameObject obstacle = Instantiate(_obstacle);
            obstacle.transform.position = new Vector3(Random.Range(-2, 2), 7, 0);
            yield return new WaitForSeconds(Random.Range(4f,6f));
        }
    }
}
