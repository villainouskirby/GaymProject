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
            for (int j = 0; j < GameManager.Instance.PlayerData.unlockGemIndex.Count; j++)
            {
                if (i == GameManager.Instance.PlayerData.unlockGemIndex[j])
                {
                    GameObject temp = Instantiate(gemIconPrefab, this.gameObject.transform);
                    temp.GetComponent<Gem>().InitData(GameManager.Instance.GemDatas.dataArray[i], sprites[i], gemInfoPanel);
                }
            }
        }
    }

}
