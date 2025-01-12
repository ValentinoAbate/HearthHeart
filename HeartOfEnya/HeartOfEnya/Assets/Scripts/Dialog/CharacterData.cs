﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newCharaData", menuName = "Character Data")]
public class CharacterData : ScriptableObject
{
    public string voiceEvent;
    public PortraitDict portraits;
    public GameObject dialogBoxPrefab;
    public GameObject dialogBoxSolo;
    public GameObject dialogBoxBattle;
    public GameObject soloBackground;

    [System.Serializable]  public class PortraitDict : SerializableCollections.SDictionary<string, Sprite> { }
}
