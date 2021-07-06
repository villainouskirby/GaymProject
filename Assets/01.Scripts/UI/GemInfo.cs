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

    public void InitGemInfoPanel(Sprite sprite, string gemName, string gemInfo)
    {
        gameObject.SetActive(true);

        gemImage.sprite = sprite;
        this.gemInfo.text = gemInfo;
        this.gemName.text = gemName;

        btnCancel.onClick.AddListener(() => gameObject.SetActive(false));
        // btnOK.onClick.AddListener() TODO : 장착하는 함수 만들기.
    }

}
