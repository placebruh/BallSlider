using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private string newGameLevel;
    [SerializeField] private string MainMenu;
 
    public void NewGameButton() 
    {
        SceneManager.LoadScene(newGameLevel);
    }
    public void LoadGameButton() 
    {
        if (PlayerPrefs.HasKey("LevelSaved")) 
        {
            string levelToLoad = PlayerPrefs.GetString("LevelSaved");
            SceneManager.LoadScene(levelToLoad);
        }
    }
    public void RestartLevel() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToMenu() 
    {
        SceneManager.LoadScene(MainMenu);
    }
}
