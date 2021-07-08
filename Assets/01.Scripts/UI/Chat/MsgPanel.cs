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
                Debug.Log("준비된 대사 끝.");
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
        nextMsgIcon.SetActive(false);
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
            Invoke(nameof(CurrentMsgFin), 0.5f);
        });
    }

    public void CallNextMsg()
    {
        if (str_Msg.Length == msgIndex)
        {
            isFinish = true;
            return;
        }

        nextMsgIcon.SetActive(false);
        isCurrentMsgFinish = false;
        msg.text = "";
        this.msg.DOText(str_Msg[msgIndex], msgTime).OnComplete(() =>
        {
            msgIndex++;
            Invoke(nameof(CurrentMsgFin), 0.5f);
        });
    }

    void CurrentMsgFin()
    {
        isCurrentMsgFinish = true;
        nextMsgIcon.SetActive(true);
    }

}
