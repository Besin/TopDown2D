using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartBtn : MonoBehaviour
{
    public InputField playerName;
    public string name;

    public void GameStart()
    {
        name = playerName.text;

        if (!string.IsNullOrEmpty(name))
        {
            PlayerPrefs.SetString("PlayerName", name);

            SceneManager.LoadScene("sample");
        }
        else
        {
            Debug.Log("닉네임을 입력하세요.");
        }
    }
}
