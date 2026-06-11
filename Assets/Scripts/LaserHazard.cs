using UnityEngine;

public class LaserHazard : MonoBehaviour
{
    public Transform checkpoint;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGER HIT: " + other.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("PLAYER HIT LASER");

            other.transform.position = checkpoint.position;
        }
    }
}