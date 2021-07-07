using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField] Image IconImage;
    [SerializeField] Image gemImage;
    [SerializeField] Button removeBtn;

    private bool isEquip = false;
    public bool IsEquip { get { return isEquip; } }

    public short index = -1;

    public void Equip(short index)
    {
        isEquip = true;
        this.index = index;
        IconImage.sprite = Resources.Load<Sprite>("Icons/SlotIcon_Fill");
        gemImage.sprite = GameManager.Instance.GemSprites[index];
        gemImage.gameObject.SetActive(true);
        removeBtn.onClick.AddListener(() => Remove());
    }
    
    public void Remove()
    {
        isEquip = false;
        IconImage.sprite = Resources.Load<Sprite>("Icons/SlotIcon_Unfill");
        gemImage.gameObject.SetActive(false);

        FindObjectOfType<GemUI>().RemoveGem(index);

        index = -1;
        removeBtn.onClick.RemoveAllListeners();
    }
}
