using UnityEngine;

public class ExitDoor : MonoBehaviour
{
    public GameObject winText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && GameManager.Instance.keyCardCount >= 5)
        {
            Debug.Log("YOU ESCAPED!");

            if (winText != null)
                winText.SetActive(true);
        }
    }
}