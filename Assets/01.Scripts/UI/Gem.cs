using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gem : MonoBehaviour
{
    [SerializeField] Image image;
    GemsData data = new GemsData();
    GemInfo infoPanel;

    bool isSelected = false;

    public void InitData(GemsData data, Sprite sprite, GemInfo infoPanel)
    {
        this.infoPanel = infoPanel;
        image.sprite = sprite;
        this.data = data;
    }

    public void OnClick()
    {
        infoPanel.InitGemInfoPanel(image.sprite, data.Name, data.Info, data.Cost);
    }

}
