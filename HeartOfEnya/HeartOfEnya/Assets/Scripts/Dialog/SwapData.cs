﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newSwapData", menuName = "Swap Data")]
public class SwapData : ScriptableObject
{
    public CharacterData replacementData;
    public GameObject replacementSoloBg;
    public Sprite replacementSprite;
    public Sprite replacementShadow;
}
