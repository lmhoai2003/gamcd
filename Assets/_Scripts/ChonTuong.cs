using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class ChonTuong : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public string playerName;
    public void chontuong1()
    {
        PlayerPrefs.SetInt("player", 0);
        playerName = "Player 1";
        PlayerPrefs.SetString("PlayerName", playerName);
        LoadGameScene();
    }

    // Gọi khi bấm chọn nhân vật 2
    public void chontuong2()
    {
        PlayerPrefs.SetInt("player", 1);
        playerName = "Player 2";
        PlayerPrefs.SetString("PlayerName", playerName);
        LoadGameScene();
    }

    private void LoadGameScene()
    {
        SceneManager.LoadScene("Map1Scene");
    }

    public string GetPlayerName()
    {
        return playerName;
    }
}
