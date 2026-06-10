using UnityEngine;
using TMPro;

public class KeyCardUI : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameManager gm;

    void Update()
    {
        text.text = "Key Cards: " + gm.keyCardCount + "/5";
    }
}
