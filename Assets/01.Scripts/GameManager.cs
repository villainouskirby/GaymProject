using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class GameManager : MonoSingleton<GameManager>
{
    [SerializeField] Gems gemData;
    public Gems GemDatas { get { return gemData; } }

    [SerializeField] Sprite[] gemSprites;
    public Sprite[] GemSprites { get { return gemSprites; } }

    PlayerData playerData = new PlayerData();
    public PlayerData PlayerData { get { return playerData; } }

    string dataPath;

    private void Awake()
    {
        dataPath = Application.persistentDataPath + "/Test.txt";
        Debug.Log(dataPath);
        LoadPlayerData();
        UnlockGemByIndex(0);
        UnlockGemByIndex(2);
    }

    public void UnlockGemByIndex(short index)
    {
        foreach (var item in playerData.unlockGemIndex)
        {
            if (item == index) return; // 이미 해금 되어있을 때 
        }
        playerData.unlockGemIndex.Add(index);
    }

    public void LoadPlayerData()
    {
        if (!File.Exists(dataPath))
        {
            SavePlayerData();
            return;
        }

        FileStream fs = new FileStream(dataPath, FileMode.Open);
        byte[] data = new byte[fs.Length];
        fs.Read(data, 0, data.Length);
        fs.Close();
        string jsonString = Encoding.UTF8.GetString(data);
        playerData = JsonUtility.FromJson<PlayerData>(jsonString);

        SavePlayerData();
    }

    public void SavePlayerData()
    {
        string jsonString = JsonUtility.ToJson(playerData);
        FileStream fs = new FileStream(dataPath, FileMode.Create);
        byte[] data = Encoding.UTF8.GetBytes(jsonString);
        fs.Write(data, 0, data.Length);
        fs.Close();
        Debug.Log(data);
    }

}
