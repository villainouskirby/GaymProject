using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Skill : MonoBehaviour
{
    public GameObject arrow;
    public GameObject skills;
    private bool selecting = false;
    private bool checking = false;
    private string user;
    private string skill;
    private string skilled;
    List<List<string>> battle = new List<List<string>>();
    
    public void check_Skill()
    {
        if (checking)
        {
            skills.SetActive(false);
            arrow.SetActive(false);
            checking = false;
        }
        else
        {
            skills.SetActive(true);
            checking = true;
            user = EventSystem.current.currentSelectedGameObject.name;
        }
    }
    public void Use()
    {
        skill = EventSystem.current.currentSelectedGameObject.name;
        arrow.SetActive(true);
        skills.SetActive(false);
        selecting = true;
    }

    public void Clicked()
    {
        if(selecting)
        {
            arrow.SetActive(false);
            checking = false;
            skilled = EventSystem.current.currentSelectedGameObject.name;
            selecting = false;
            List<string> lst = new List<string>();
            lst.Add(user);
            lst.Add(skill);
            lst.Add(skilled);
            battle.Add(lst);
            for (int i=0; i<battle.Count;i++)
            {
                if (lst[0] == battle[i][0])
                {
                    battle[i] = lst;
                }
                else
                    battle.Add(lst);
            }
        }   // 디버그 필요
    }

    public void play_btn()
    {
        for (int i=0; i<battle.Count;i++)
        {
            for (int j=0; j<3;j++)
            {
                Debug.Log(battle[i][j]);
            }
        }    
    }
}
