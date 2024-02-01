using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private GameObject _rocket;
    [SerializeField] private GameObject _plane;

    public void ShootButton()
    {
        GameObject rocket = Instantiate(_rocket);
        rocket.transform.position = new Vector3(_plane.transform.position.x, _plane.transform.position.y, _plane.transform.position.z);
    }
}