using UnityEngine;

public class KeyCard : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.AddKeyCard();
            Destroy(gameObject);
        }
    }
}