using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class GameManager : MonoSingleton<GameManager>
{
    [SerializeField] Gems gemData;
    public Gems GemDatas { get { return gemData; } }

    PlayerData playerData = new PlayerData(3, 3);

    string dataPath;

    private void Awake()
    {
        dataPath = Application.persistentDataPath + "Test";
        Debug.Log(dataPath);
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
    }

    public void SavePlayerData()
    {
        string jsonString = JsonUtility.ToJson(playerData);
        FileStream fs = new FileStream(dataPath, FileMode.Create);
        byte[] data = Encoding.UTF8.GetBytes(jsonString);
        fs.Write(data, 0, data.Length);
        fs.Close();
        Debug.Log("JSON : " + jsonString);
    }

}
