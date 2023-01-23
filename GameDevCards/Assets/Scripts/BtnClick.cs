using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnClick : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void Library()
    {
        SceneManager.LoadScene("Library");
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void LoadIntro()
    {
        SceneManager.LoadScene("Intro");
    }
    public void Load1()
    {
        SceneManager.LoadScene("MainGame");
    }
    public void Load2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void Load3()
    {
        SceneManager.LoadScene("Level 3");
    }
    public void Load4()
    {
        SceneManager.LoadScene("Level 4");
    }
    public void Load5()
    {
        SceneManager.LoadScene("Level 5");
    }
    public void Load6()
    {
        SceneManager.LoadScene("Level 6");
    }
    public void LoadEnding()
    {
        SceneManager.LoadScene("Ending");
    }
}