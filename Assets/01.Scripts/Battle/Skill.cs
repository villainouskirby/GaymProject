using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Skill : MonoBehaviour
{
    public GameObject arrow;
    public GameObject skills;
    public bool using_skill = false;
    public string skill_user;
    public string used_skill;
    public List<List<string>> attack_lst = new List<List<string>>();
    public void Use()
    {
        skills.SetActive(false);
        arrow.SetActive(true);
        using_skill = true;
        used_skill = EventSystem.current.currentSelectedGameObject.name;
    }
}
