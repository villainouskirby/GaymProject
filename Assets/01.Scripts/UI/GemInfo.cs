using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemInfo : MonoBehaviour
{
    [SerializeField] Button btnCancel;
    [SerializeField] Button btnOK;
    [SerializeField] Image gemImage;
    [SerializeField] Text gemName;
    [SerializeField] Text gemInfo;
    [SerializeField] Text gemCost;

    public void InitGemInfoPanel(Sprite sprite, GemsData data)
    {
        gameObject.SetActive(true);

        gemImage.sprite = sprite;
        this.gemInfo.text = data.Info;
        this.gemName.text = data.Name;
        this.gemCost.text = $"ÄÚ½ºÆ® : {data.Cost}";

        btnCancel.onClick.AddListener(() =>
        {
            gameObject.SetActive(false);
            btnOK.onClick.RemoveAllListeners();
        });

        btnOK.onClick.AddListener(() => 
        {
            FindObjectOfType<GemUI>().SetGem(data.Index, out bool isSuccess);

            if(!isSuccess) { return; }

            Gem[] temp =  FindObjectsOfType<Gem>();
            for (int i = 0; i < temp.Length; i++)
            {
                if(temp[i].Data.Index == data.Index)
                {
                    temp[i].GetComponent<Button>().interactable = false;
                }
            }

            gameObject.SetActive(false);
            btnOK.onClick.RemoveAllListeners();
        });
    }

}
