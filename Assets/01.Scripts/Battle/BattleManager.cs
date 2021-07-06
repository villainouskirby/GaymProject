using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class BattleManager : MonoBehaviour
{
    public GameObject Actor;
    private GameObject c_obj;
    private object isplayer;
    private List<List<object>> characters = new List<List<object>>();
    /*private void Start()
    {
        
        for (int i = 0; i < Actor.transform.childCount; i++)
        {
            c_obj = Actor.transform.GetChild(i).gameObject;
            List<object> c_data = new List<object>(GameObject.Find(c_obj.name).GetComponent<BattleInformation>().data.Values);
            characters.Add(c_data);
            isplayer = GameObject.Find(c_obj.name).GetComponent<BattleInformation>().isplayer;
            characters[i].Add(isplayer);
        }
    }*/
}
