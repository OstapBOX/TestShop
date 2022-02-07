using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static PlayerData instance { get; private set; }

    private int coinsAmount;
    private int diamondsAmount;

    private void Awake() {
        coinsAmount = PlayerPrefs.GetInt("coinsAmount", 0);
        diamondsAmount = PlayerPrefs.GetInt("diamondsAmount", 0);

        if(instance == null) {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            return;
        }
        Destroy(this.gameObject);
    }

    
    public bool TryRemoveMoney(int moneyToRemove) {
        if(coinsAmount >= moneyToRemove) {
            SubtractCoins(moneyToRemove);
            return true;
        }
        else {
            return false;
        }
    }

    public int GetCoinsAmount() {
        coinsAmount = PlayerPrefs.GetInt("coinsAmount", 0);
        return coinsAmount;
    }

    public void AddCoins(int _coinsAmount) {
        PlayerPrefs.SetInt("coinsAmount", PlayerPrefs.GetInt("coinsAmount", 0) + _coinsAmount);
        coinsAmount = PlayerPrefs.GetInt("coinsAmount", 0);
    }

    public void SubtractCoins(int _coinsAmount) {
        PlayerPrefs.SetInt("coinsAmount", PlayerPrefs.GetInt("coinsAmount", 0) - _coinsAmount);
        coinsAmount = PlayerPrefs.GetInt("coinsAmount", 0);
    }



    public int GetDiamondsAmount() {
        diamondsAmount = PlayerPrefs.GetInt("diamondsAmount", 0);
        return diamondsAmount;
    }

    public void AddDiamonds(int _diamondsAmount) {
        PlayerPrefs.SetInt("diamondsAmount", PlayerPrefs.GetInt("diamondsAmount", 0) + _diamondsAmount);
        coinsAmount = PlayerPrefs.GetInt("diamondsAmount", 0);
    }

    public void SubtractDiamonds(int _diamondsAmount) {
        PlayerPrefs.SetInt("diamondsAmount", PlayerPrefs.GetInt("diamondsAmount", 0) - _diamondsAmount);
        coinsAmount = PlayerPrefs.GetInt("diamondsAmount", 0);
    }
}
