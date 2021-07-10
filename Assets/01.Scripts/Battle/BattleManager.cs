using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class BattleManager : MonoBehaviour
{
    public GameObject Actor;
    List<BattleInformation> scripts = new List<BattleInformation>();
    private void Start()
    {
        foreach (BattleInformation script in Actor.GetComponentsInChildren<BattleInformation>(true))
        {
            scripts.Add(script);
        }
    }
}
