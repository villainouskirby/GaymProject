using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemUI : MonoBehaviour
{
    [SerializeField] GameObject[] costIcons;
    [SerializeField] GameObject[] slotIcons;
 
    private short currentCost;
    private short maxCost;
    private short maxSlot;

    private void Start()
    {
        maxCost = GameManager.Instance.PlayerData.maximumGemCost;
        maxSlot = GameManager.Instance.PlayerData.maximumSlot;
        InitInventory();
    }

    private void InitInventory()
    {
        for (int i = 0; i < maxCost; i++)
        {
            costIcons[i].SetActive(true);
        }

        for (int i = 0; i < maxSlot; i++)
        {
            slotIcons[i].SetActive(true);
        }
    }
    
    public void SetGem(short index, out bool isSuccess)
    {
        if(GameManager.Instance.GemDatas.dataArray[index].Cost + currentCost > maxCost)
        {
#if UNITY_EDITOR
            Debug.Log("코스트가 꽉찼습니다!");
#endif
            isSuccess = false;
            return;
        }

        for (int i = 0; i < maxSlot; i++)
        {
            if (slotIcons[i].GetComponent<Slot>().index == index)
            {
#if UNITY_EDITOR
                Debug.Log(index + " 번 슬롯에 이미 장착된 보석입니다!");
#endif
                isSuccess = false;
                return;
            }
        }

        for (int i = 0; i < maxSlot; i++)
        {
            if (!slotIcons[i].GetComponent<Slot>().IsEquip)
            {
                currentCost += GameManager.Instance.GemDatas.dataArray[index].Cost;

                UpdateCostIcons();

                slotIcons[i].GetComponent<Slot>().Equip(index);
                isSuccess = true;
                return;
            }
        }
        isSuccess = false;
    }
    
    public void RemoveGem(short index)
    {
        for (int i = 0; i < maxSlot; i++)
        {
            if (slotIcons[i].GetComponent<Slot>().index == index)
            {
                currentCost -= GameManager.Instance.GemDatas.dataArray[index].Cost;
            }
        }

        Gem[] temp = FindObjectsOfType<Gem>();
        for (int i = 0; i < temp.Length; i++)
        {
            if (temp[i].Data.Index == index)
            {
                temp[i].GetComponent<Button>().interactable = true;
            }
        }

        UpdateCostIcons();
    }

    private void UpdateCostIcons()
    {
        for (int i = 0; i < maxCost; i++)
        {
            if(i < currentCost)
            {
                costIcons[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("Icons/SlotIcon_fill");
            }
            else
            {
                costIcons[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("Icons/SlotIcon_Unfill");
            }
        }
    }
}
