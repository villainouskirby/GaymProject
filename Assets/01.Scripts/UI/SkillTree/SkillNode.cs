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
        leftLower,
    };

    [SerializeField] NodePos thisPos;
    [SerializeField] short rootDistance = 0;

    [SerializeField] bool bCanUpgrade = false;

    public bool BCanUpgrade { get { return bCanUpgrade; } set { bCanUpgrade = value; } }

}
