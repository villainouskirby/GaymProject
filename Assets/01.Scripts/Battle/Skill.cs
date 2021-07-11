using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Skill : MonoBehaviour
{
    public GameObject arrow;
    public GameObject skills;
    public bool using_skill = false;
    string skilled;
    public void Use()
    {
        skills.SetActive(false);
        arrow.SetActive(true);
        using_skill = true;
    }
}
