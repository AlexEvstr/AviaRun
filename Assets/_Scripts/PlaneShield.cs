using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneShield : MonoBehaviour
{
    private void Update()
    {
        GameObject shield = GameObject.FindGameObjectWithTag("Shield");

        if (shield != null)
        {
            Debug.Log("shielded");
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
