using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinsText;
    [SerializeField] private TextMeshProUGUI diamandsText;

    private void Update() {
        coinsText.text = PlayerData.instance.GetCoinsAmount().ToString();
        diamandsText.text = PlayerData.instance.GetDiamondsAmount().ToString();
    }
}
