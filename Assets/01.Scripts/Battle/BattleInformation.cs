using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BattleInformation : MonoBehaviour
{
    public GameObject Profile;
    public int character_idx;
    public string Style;
    public string Name;
    public float HP;
    public float MP;
    public string Passive;
    public Text t_Style;
    public Text t_Name;
    public Text t_HP;
    public Text t_MP;
    public Text t_Passive;
    public bool isplayer;
    public Dictionary<string, object> data;
    public GameObject arrow;
    public GameObject skills;
    public Skill skillscript;
    public GameObject mine;
    string skilled;

    // Start is called before the first frame update
    void Awake()
    {
        if ((int)HP == HP)
            HP = (float)(int)HP;
        if ((int)MP == MP)
            MP = (float)(int)MP;
    }
    void OnMouseEnter()
    {
        Profile.SetActive(true);
        t_Style.text = "칭호 : " + Style;
        t_Name.text = "이름 : " + Name;
        t_HP.text = "HP : " + HP.ToString();
        t_MP.text = "MP : " + MP.ToString();
        t_Passive.text = "패시브\n" + Passive;
    }

    private void OnMouseDown()
    {
        if (skillscript.using_skill)
        {
            arrow.SetActive(false);
            Debug.Log(mine.name);
            skillscript.using_skill = false;
        }
        else
            skills.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
