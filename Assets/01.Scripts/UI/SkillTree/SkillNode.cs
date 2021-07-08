using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillNode : MonoBehaviour
{
    [SerializeField] LineRenderer[] lines;
    [SerializeField] Transform[] destinations;
    [SerializeField] NodePos thisPos;
    [SerializeField] short rootDistance = 0;

    [SerializeField] bool bCanUpgrade = false;
    public bool BCanUpgrade { get { return bCanUpgrade; } set { bCanUpgrade = value; } }

    public enum NodePos
    {
        rightUpper,
        rightLower,
        leftUpper,
        leftLower,
    };

    private void Update()
    {
        for (int i = 0; i < destinations.Length; i++)
        {
            if(destinations[i] != null)
            {
                lines[i].SetPosition(0, (new Vector3(lines[i].transform.position.x, lines[i].transform.position.y, 1)));
                lines[i].SetPosition(1, (new Vector3(destinations[i].position.x, destinations[i].position.y, 1)));
            }
        }
    }

}
