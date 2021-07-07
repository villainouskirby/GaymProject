using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public short maximumGemCost = 3;
    public short maximumSlot = 3;
    public List<short> unlockGemIndex = new List<short>();
}
