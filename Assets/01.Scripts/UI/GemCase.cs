using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCase : MonoBehaviour
{
    [SerializeField] GameObject gemIconPrefab = null;
    [SerializeField] GemInfo gemInfoPanel;
    [SerializeField] Sprite[] sprites = null;

    void Start()
    {
        MakeGems();
    }

    void MakeGems()
    {
        for (int i = 0; i < GameManager.Instance.GemDatas.dataArray.Length; i++)
        {
            GameObject temp = Instantiate(gemIconPrefab, this.gameObject.transform);
            temp.GetComponent<Gem>().InitData(GameManager.Instance.GemDatas.dataArray[i], sprites[i], gemInfoPanel);
        }
    }

}
