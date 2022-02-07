using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    public static SkinManager instance { get; private set; }
    public SSkinInfo[] allSkins;

    private void Awake() {
        if(instance == null) {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            return;
        }
        Destroy(this.gameObject);
    }

    public static int equippedSkinID;

    public void EquipSkin(SSkinInfo skinInfo) {
        equippedSkinID = skinInfo.skinIDInt;
        PlayerPrefs.SetString("skinPref", skinInfo.skinIDInt.ToString());
    }
}
