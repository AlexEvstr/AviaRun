using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _shieldBonus;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            GameObject shield = Instantiate(_shieldBonus);
            shield.transform.position = new Vector3(Random.Range(-2, 2), 7, 0);
            yield return new WaitForSeconds(Random.Range(20f, 30f));
        }
    }
}
