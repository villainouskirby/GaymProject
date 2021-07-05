using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    void Awake()
    {
        talkData = new Dictionary<int, string[]>();
        GenerateData();
    }

    void GenerateData()
    {
        talkData.Add(0, new string[] { "������ : (������ �ڵ����� ������ �Ҹ�) ���� �����ߴ�!" });
        talkData.Add(1, new string[] { "������ : �� �̸��� ���Ÿ�� ������.", "�Ϻ����� �ѱ����� ���� �� ���л��̴�." });
        talkData.Add(2, new string[] { "������ : �� �׷�...", "���� �� ������ ����� ����?" });
        talkData.Add(3, new string[] { "������ : ��...���� �� Ǯ����...", "���б� OT�� �� ���缭 �� �� �ְڴ�!", "���� ����غ���~" });
        talkData.Add(4, new string[] { "���б��� : ����, ���� �б���..." });
        talkData.Add(5, new string[] { "������ : �Ͼ�...�������� �����ϳ�...", "���� �����°���..." });
        talkData.Add(6, new string[] { "??? : (����) ��! ��!" });
        talkData.Add(7, new string[] { "������ : ��...��?" });
        talkData.Add(8, new string[] { "??? : ���Ի��� �� ������...�̸��� ����?" });
        talkData.Add(9, new string[] { "�Ѽ��� : �׷�? �� �Ѽ����̶�� ��! ������ �� ��Ź��!" });
        talkData.Add(10, new string[] { "������ : (�������� ���) ����...���� ������...", "���� ���� �� �����ϰ� �� ����߰ھ�..." });
        talkData.Add(12, new string[] { "������ : �׷���...�ƹ��� ���̶�� �ص� ��Ÿ��� ����� �̷��Գ� ����...?", "���� �ȴٴϰ�..." });
        talkData.Add(13, new string[] { "������ : ..���...", "����...�̻���..." });
        talkData.Add(14, new string[] { "??? : ...ã�Ҵ�." });
        talkData.Add(15, new string[] { "??? : ���̾�...�ʸ� ��û�Ϸ� �Դ�." });
    }

    public string GetTalk(int id, int TalkIdx)
    {
        return talkData[id][TalkIdx];
    }
}
