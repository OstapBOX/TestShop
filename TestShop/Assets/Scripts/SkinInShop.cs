using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Purchasing;

public class SkinInShop : MonoBehaviour
{
    public SSkinInfo skinInfo;
    public Text buttonText;
    public Image skinImage;
    public bool isSkinUnlocked;

    private void Awake() {
        IsSkinUnlocked();
    }

    private void Update() {
      
    }

    public void OnButtonPress() {
        {
            Debug.Log(skinInfo.skinIDInt);
            if (isSkinUnlocked) {
                SkinManager.instance.EquipSkin(skinInfo);
            }
            else {
                if (PlayerData.instance.TryRemoveMoney(skinInfo.skinPrice)) {
                    PlayerPrefs.SetInt(skinInfo.skinIDInt.ToString(), 1);
                    IsSkinUnlocked();
                }
            }
        }
    }

    public void IsSkinUnlocked() {
        if (PlayerPrefs.GetInt(skinInfo.skinIDInt.ToString()) == 1) {
            isSkinUnlocked = true;
            buttonText.text = "Use";
        }
    }
}
