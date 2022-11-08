using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController: MonoBehaviour
{
	//Button to load Chapters
    public void ToChapters()
    {
        SceneManager.LoadScene("Chapters");
    }
	
	//Button to Open Options
    public void ToOptions()
    {   //Pop-Menu sliders for options
        Debug.Log("Pop-Up Menu Options");
    }
	
	//Button to load Gallery
    public void ToGallery()
    {
        SceneManager.LoadScene("Gallery");
    }
	
	//Button to Exit Game
    public void ExitGame()
    {
        Application.Quit();
    }
	

}
