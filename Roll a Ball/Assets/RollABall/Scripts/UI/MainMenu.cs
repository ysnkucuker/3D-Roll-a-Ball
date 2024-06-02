using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private int levelData;
    public void StartGame()
    {
        Time.timeScale = 1.0f;
        levelData = PlayerPrefs.GetInt("levelData", 1);
        LoadLevelScene();
    }

    public void LoadLevelScene()
    {
        SceneManager.LoadScene(levelData);
    }

    public void ResetGame()
    {
        PlayerPrefs.SetInt("levelData", 1);
        PlayerPrefs.SetInt("goldData", 0);
        StartGame();
    }
}
