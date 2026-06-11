using UnityEngine;

public class LaserHazard : MonoBehaviour
{
    public Transform checkpoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("PLAYER HIT LASER");

            CharacterController controller = other.GetComponent<CharacterController>();

            if (controller != null)
            {
                controller.enabled = false;
                other.transform.position = checkpoint.position;
                controller.enabled = true;
            }
            else
            {
                other.transform.position = checkpoint.position;
            }
        }
    }
}