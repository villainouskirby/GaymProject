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
        talkData.Add(0, new string[] { "마코토 : (공항의 자동문이 열리는 소리) 드디어 도착했다!" });
        talkData.Add(1, new string[] { "마코토 : 내 이름은 사와타리 마코토.", "일본에서 한국으로 오게 된 유학생이다." });
        talkData.Add(2, new string[] { "마코토 : 자 그럼...", "내가 살 집으로 출발해 볼까?" });
        talkData.Add(3, new string[] { "마코토 : 후...짐은 다 풀었고...", "대학교 OT에 딱 맞춰서 갈 수 있겠다!", "이제 출발해볼까~" });
        talkData.Add(4, new string[] { "대학교장 : 먼저, 저희 학교는..." });
        talkData.Add(5, new string[] { "마코토 : 하암...생각보다 지루하네...", "언제 끝나는거지..." });
        talkData.Add(6, new string[] { "??? : (툭툭) 야! 야!" });
        talkData.Add(7, new string[] { "마코토 : 으...응?" });
        talkData.Add(8, new string[] { "??? : 신입생인 것 같은데...이름이 뭐야?" });
        talkData.Add(9, new string[] { "한수진 : 그래? 난 한수진이라고 해! 앞으로 잘 부탁해!" });
        talkData.Add(10, new string[] { "마코토 : (기지개를 펴며) 으윽...드디어 끝났다...", "집에 가면 짐 정리하고 좀 쉬어야겠어..." });
        talkData.Add(12, new string[] { "마코토 : 그런데...아무리 밤이라고 해도 길거리에 사람이 이렇게나 없나...?", "차도 안다니고..." });
        talkData.Add(13, new string[] { "마코토 : ..잠깐...", "뭔가...이상한..." });
        talkData.Add(14, new string[] { "??? : ...찾았다." });
        talkData.Add(15, new string[] { "??? : 라이엇...너를 숙청하러 왔다." });
    }

    public string GetTalk(int id, int TalkIdx)
    {
        return talkData[id][TalkIdx];
    }
}
