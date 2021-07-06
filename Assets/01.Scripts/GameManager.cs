using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    [SerializeField] Gems gemData;
    public Gems GemDatas { get { return gemData; } }
}
