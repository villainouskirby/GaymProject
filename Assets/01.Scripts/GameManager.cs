using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    string[] teststrings = { "다람쥐 헌 쳇바퀴에 타고파.", "그들의 장비와 기구는 모두 살아있다."};

    private void Start()
    {
        CallMsgPanel(teststrings);
    }

    void CallMsgPanel(string[] msgs)
    {
        FindObjectOfType<MsgPanel>().InitMsgPanel("개발자", "커비" , msgs);
    }
    

}
