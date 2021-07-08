using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTree : MonoBehaviour
{
    [SerializeField] SkillNode rootNode;
    
    [SerializeField] List<SkillNode> rightUpperNodes = new List<SkillNode>();
    [SerializeField] List<SkillNode> rightLowerNodes = new List<SkillNode>();
    [SerializeField] List<SkillNode> leftUpperNodes = new List<SkillNode>();
    [SerializeField] List<SkillNode> leftLowerNodes = new List<SkillNode>();

    private void Start()
    {

    }

    void UpdateAllNodes()
    {

    }
}
