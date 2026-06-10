using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int keyCardCount = 0;

    private void Awake()
    {
        Instance = this;
    }

    public void AddKeyCard()
    {
        keyCardCount++;
        Debug.Log("Key Cards: " + keyCardCount);
    }
}