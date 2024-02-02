using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while(true)
        {
            GameObject rocket = Instantiate(_enemy);
            rocket.transform.position = new Vector3(Random.Range(-2,2), 7, 0);
            yield return new WaitForSeconds(3);
        }
    }

}
