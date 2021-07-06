using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("Scene1");
    }
    public void SettingButton()
    {
        Debug.Log("¼³Á¤");
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
