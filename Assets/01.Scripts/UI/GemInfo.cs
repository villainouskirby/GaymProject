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

    public void InitGemInfoPanel(Sprite sprite, string gemName, string gemInfo, short gemCost)
    {
        gameObject.SetActive(true);

        gemImage.sprite = sprite;
        this.gemInfo.text = gemInfo;
        this.gemName.text = gemName;
        this.gemCost.text = $"코스트 : {gemCost}";

        btnCancel.onClick.AddListener(() => gameObject.SetActive(false));
        // btnOK.onClick.AddListener() TODO : 장착하는 함수 만들기.
    }

}
