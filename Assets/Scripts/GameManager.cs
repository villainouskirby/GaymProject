using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<Dictionary<string,object>> data;
    void Awake()
    {
        data = CSVReader.Read("Character");
    }
    //public TalkManager talkManager;
    //public Text talktxt;
    //public int talkIdx;
    void Start()
    {
        
    }

}

    //void Talk(int id)
    //{
    //    string talkData = talkManager.GetTalk(id, talkIdx);
    //
    //    talktxt.text = talkData;
    //
    //    talkIdx++;
    //}

