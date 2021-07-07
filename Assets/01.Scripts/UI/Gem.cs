using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gem : MonoBehaviour
{
    [SerializeField] Image image;
    GemsData data = new GemsData();
    public GemsData Data { get { return data; } }
    GemInfo infoPanel = null;

    public void InitData(GemsData data, Sprite sprite, GemInfo infoPanel)
    {
        this.infoPanel = infoPanel;
        image.sprite = sprite;
        this.data = data;
        this.GetComponent<Button>().onClick.AddListener(() => infoPanel.InitGemInfoPanel(image.sprite, data));
    }

}
