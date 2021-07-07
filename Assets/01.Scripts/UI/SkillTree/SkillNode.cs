using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillNode : MonoBehaviour
{
    public enum NodePos
    {
        rightUpper,
        rightLower,
        leftUpper,
        leftLower
    };  

    [SerializeField] List<SkillNode> parentNodes = new List<SkillNode>(); 
    [SerializeField] List<SkillNode> childrenNodes = new List<SkillNode>();

    [SerializeField] short rootDistance = 0;
    [SerializeField] bool bCanUpgrade = false;
    public bool BCanUpgrade { get { return bCanUpgrade; } set { bCanUpgrade = value; } }
    

}
