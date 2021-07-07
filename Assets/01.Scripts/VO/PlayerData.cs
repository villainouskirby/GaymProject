using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    short maximumGemCost = 3;
    short maximumSlot = 3;

    public PlayerData(short maximumGemCost, short maximumSlot)
    {
        this.maximumGemCost = maximumGemCost;
        this.maximumSlot = maximumSlot;
    }

    public void InitPlayerData(short maximumGemCost, short maximumSlot)
    {
        this.maximumGemCost = maximumGemCost;
        this.maximumSlot = maximumSlot;
    }
}
