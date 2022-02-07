using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public void AddCoins(int _coinsAmount) {
        PlayerData.instance.AddCoins(_coinsAmount);
    }

    public void SubtractCoins(int _coinsAmount) {
        PlayerData.instance.SubtractCoins(_coinsAmount);
    }
}
