using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        t_Style.text = "Īȣ : " + Style;
        t_Name.text = "�̸� : " + Name;
        t_HP.text = "HP : " + HP.ToString();
        t_MP.text = "MP : " + MP.ToString();
        t_Passive.text = "�нú�\n" + Passive;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
