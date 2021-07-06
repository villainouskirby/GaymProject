using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class MsgPanel : MonoBehaviour
{
    [SerializeField] Text faction;
    [SerializeField] Text charName;
    [SerializeField] Text msg;
    [SerializeField] GameObject nextMsgIcon;
    [SerializeField] float msgTime;
    
    string[] str_Msg;

    bool isFinish = false;
    bool isCurrentMsgFinish = false;
    int msgIndex = 0;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (isFinish)
            {
                Debug.Log("�غ�� ��� ��.");
                return;
                //Finish ALL.
                //this.gameObject.SetActive(false);
            }

            this.msg.DOComplete();

            if (isCurrentMsgFinish)
            {
                CallNextMsg();
            }

        }
    }

    /// <summary>
    /// Init Messages into MsgPanel
    /// </summary>
    /// <param name="name">Name</param>
    /// <param name="msg">Message</param>
    /// <param name="msgTime">Time</param>
    public void InitMsgPanel(string faction, string name, string[] msg)
    {
        gameObject.SetActive(true);
        str_Msg = msg;
        this.faction.text = faction;
        this.charName.text = name;
        if (str_Msg.Length == msgIndex)
        {
            isFinish = true;
            return;
        }
        this.msg.DOText(msg[msgIndex], msgTime).OnComplete(() =>
        {
            msgIndex++;
            Invoke(nameof(currentMsgFin), 1f);
        });
    }

    public void CallNextMsg()
    {
        if (str_Msg.Length == msgIndex)
        {
            isFinish = true;
            return;
        }

        isCurrentMsgFinish = false;
        msg.text = "";
        this.msg.DOText(str_Msg[msgIndex], msgTime).OnComplete(() =>
        {
            msgIndex++;
            Invoke(nameof(currentMsgFin), 1f);
        });
    }

    void currentMsgFin()
    {
        isCurrentMsgFinish = true;
    }

}