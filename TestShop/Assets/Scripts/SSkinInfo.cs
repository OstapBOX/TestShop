using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Skin", menuName ="Create New Skin")]
public class SSkinInfo : ScriptableObject
{
    public int skinIDInt;
    public Sprite skinSprite;
    public int skinPrice;
}
