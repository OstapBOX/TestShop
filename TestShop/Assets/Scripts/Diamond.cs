using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    public void AddDiamonds(int _diamondsAmount) {
        PlayerData.instance.AddDiamonds(_diamondsAmount);
    }

    public void SubtractDiamonds(int _diamondsAmount) {
        PlayerData.instance.SubtractDiamonds(_diamondsAmount);
    }
}
