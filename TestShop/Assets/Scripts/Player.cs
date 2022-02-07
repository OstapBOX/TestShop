using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public GameObject[] skinItems;
    private void Awake() {
        skinItems[SkinManager.equippedSkinID].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
