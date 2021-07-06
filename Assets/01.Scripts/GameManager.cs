using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    string[] teststrings = { "�ٶ��� �� �¹����� Ÿ����.", "�׵��� ���� �ⱸ�� ��� ����ִ�."};

    private void Start()
    {
        CallMsgPanel(teststrings);
    }

    void CallMsgPanel(string[] msgs)
    {
        FindObjectOfType<MsgPanel>().InitMsgPanel("������", "Ŀ��" , msgs);
    }
    

}
