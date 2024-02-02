using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldCollision : MonoBehaviour
{ 
    [SerializeField] private GameObject _shieldOnPlane;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Debug.Log("bonus");
            TurnOnShield();
        }
    }

    private void TurnOnShield()
    {
        GameObject plane = GameObject.FindGameObjectWithTag("Player");
        var shield = Instantiate(_shieldOnPlane);
        shield.transform.SetParent(plane.transform);
        shield.transform.position = new Vector3(plane.transform.position.x, plane.transform.position.y, plane.transform.position.z);

        Destroy(shield, 5);
    }
}