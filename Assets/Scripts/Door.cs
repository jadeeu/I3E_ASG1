using UnityEngine;

public class Door : MonoBehaviour
{
    public int requiredKeys = 2;
    private bool isOpen = false;

    void Update()
    {
        if (!isOpen && GameManager.Instance.keyCardCount >= requiredKeys)
        {
            OpenDoor();
        }
    }

    void OpenDoor()
    {
        isOpen = true;
        gameObject.SetActive(false);
    }
}